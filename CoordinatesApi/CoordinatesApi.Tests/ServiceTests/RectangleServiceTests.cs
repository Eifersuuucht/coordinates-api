using System.Collections.Immutable;
using CoordinatesApi.Core.Models.Rectangles;
using CoordinatesApi.Core.Services;
using CoordinatesApi.Data.Entities;
using CoordinatesApi.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Moq;

namespace CoordinatesApi.Tests.ServiceTests;

[TestClass]
public class RectangleServiceTests
{
    private Mock<IServiceScopeFactory> _mockScopeFactory;
    private Mock<IServiceScope> _mockScope;
    private Mock<IServiceProvider> _mockServiceProvider;
    private Mock<IRectangleRepository> _mockRectangleRepository;
    private RectangleService _rectangleService;

    [TestInitialize]
    public void SetUp()
    {
        _mockScopeFactory = new Mock<IServiceScopeFactory>();
        _mockScope = new Mock<IServiceScope>();
        _mockRectangleRepository = new Mock<IRectangleRepository>();
        _rectangleService = new RectangleService(_mockScopeFactory.Object);

        _mockScopeFactory.Setup(x => x.CreateScope()).Returns(_mockScope.Object);
        _mockScope.Setup(x => x.ServiceProvider.GetService(typeof(IRectangleRepository)))
            .Returns(_mockRectangleRepository.Object);
    }

    [TestMethod]
    public async Task MatchCoordinatesAsync_ShouldReturnCorrectMatchResult()
    {
        var coordinates = new List<CoordinateModel> { new (X: 10, Y: 20) };
        var rectangles = new List<Rectangle> { new() }.ToImmutableList();
        _mockRectangleRepository.Setup(r => r.FindMatchingRectanglesAsync(It.IsAny<int>(), It.IsAny<int>()))
                                .ReturnsAsync(rectangles);

        var result = await _rectangleService.MatchCoordinatesAsync(coordinates.ToImmutableList());

        Assert.AreEqual(1, result.MatchResults.Count);
    }

    [TestMethod]
    public async Task MatchCoordinatesAsync_ShouldCallRepositoryForEachCoordinate()
    {
        var coordinates = new List<CoordinateModel>
        {
            new (X: 10, Y: 20),
            new (X: 30, Y: 40)
        };
        var rectangles = new List<Rectangle> { new() }.ToImmutableList();
        _mockRectangleRepository.Setup(r => r.FindMatchingRectanglesAsync(It.IsAny<int>(), It.IsAny<int>()))
            .ReturnsAsync(rectangles);

        await _rectangleService.MatchCoordinatesAsync(coordinates.ToImmutableList());

        _mockRectangleRepository.Verify(r => r.FindMatchingRectanglesAsync(It.IsAny<int>(), It.IsAny<int>()), Times.Exactly(coordinates.Count));
    }

    [TestMethod]
    public async Task MatchCoordinateAsync_ShouldReturnRectanglesForCoordinate()
    {
        var coordinate = new CoordinateModel(X: 10, Y: 20);
        var rectangles = new List<Rectangle> { new() }.ToImmutableList();
        _mockRectangleRepository.Setup(r => r.FindMatchingRectanglesAsync(It.IsAny<int>(), It.IsAny<int>()))
                                .ReturnsAsync(rectangles);

        var (returnedCoordinate, returnedRectangles) = await _rectangleService.MatchCoordinateAsync(coordinate);

        Assert.AreEqual(coordinate, returnedCoordinate);
        Assert.AreEqual(rectangles.Count, returnedRectangles.Count);
    }
}

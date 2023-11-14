using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoordinatesApi.Data.Contexts;
using CoordinatesApi.Data.Entities;
using CoordinatesApi.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CoordinatesApi.Tests.RepositoryTests;

[TestClass]
public class RectangleRepositoryTests
{
    private AppDbContext _dbContext;
    private RectangleRepository _rectangleRepository;
    private DbContextOptions<AppDbContext> _options;

    [TestInitialize]
    public void SetUp()
    {
        _options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _dbContext = new AppDbContext(_options);
        _rectangleRepository = new RectangleRepository(_dbContext);

        SeedDatabase();
    }

    private void SeedDatabase()
    {
        var rectangles = new List<Rectangle>
        {
            new Rectangle { X1 = 10, Y1 = 10, X2 = 20, Y2 = 20 },
            new Rectangle { X1 = 15, Y1 = 15, X2 = 25, Y2 = 25 },
        };

        _dbContext.Rectangles.AddRange(rectangles);
        _dbContext.SaveChanges();
    }

    [TestMethod]
    public async Task FindMatchingRectanglesAsync_ShouldReturnMatchingRectangles()
    {
        var matchingRectangles = await _rectangleRepository.FindMatchingRectanglesAsync(15, 15);

        Assert.IsTrue(matchingRectangles.Any());
        Assert.AreEqual(2, matchingRectangles.Count);
    }

    [TestMethod]
    public async Task FindMatchingRectanglesAsync_ShouldReturnEmptyList_WhenNoMatch()
    {
        var matchingRectangles = await _rectangleRepository.FindMatchingRectanglesAsync(1, 1);

        Assert.IsFalse(matchingRectangles.Any());
    }

    [TestMethod]
    public async Task FindMatchingRectanglesAsync_ShouldReturnEmptyList_WhenDatabaseIsEmpty()
    {
        _dbContext.Rectangles.RemoveRange(_dbContext.Rectangles);
        _dbContext.SaveChanges();

        var matchingRectangles = await _rectangleRepository.FindMatchingRectanglesAsync(15, 15);

        Assert.IsFalse(matchingRectangles.Any());
    }

    [TestCleanup]
    public void CleanUp()
    {
        _dbContext.Dispose();
    }
}

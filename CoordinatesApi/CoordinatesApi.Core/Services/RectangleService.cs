using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using CoordinatesApi.Core.Models;
using CoordinatesApi.Core.Models.Rectangles;
using CoordinatesApi.Data.Entities;
using CoordinatesApi.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CoordinatesApi.Core.Services;

public sealed class RectangleService : IRectangleService
{
    private readonly IServiceScopeFactory _scopeFactory;

    public RectangleService(IServiceScopeFactory scopeFactory)
    {
        _scopeFactory = scopeFactory;
    }

    public async Task<MatchResultModel> MatchCoordinatesAsync(IImmutableList<CoordinateModel> coordinates)
    {
        var tasks = coordinates.Select(MatchCoordinateAsync).ToList();

        var taskResults = await Task.WhenAll(tasks);

        var singleMatchResults = taskResults
            .Select(result => new SingleMatchResultModel(
                result.Coordinate, 
                result.Rectangles.Select(MapToRectangleModel).ToImmutableList()))
            .ToImmutableList();

        var matchResult = new MatchResultModel(singleMatchResults);

        return matchResult;
    }

    public async Task<(CoordinateModel Coordinate, IImmutableList<Rectangle> Rectangles)> MatchCoordinateAsync(CoordinateModel coordinate)
    {
        using (var scope = _scopeFactory.CreateScope())
        {
            var repository = scope.ServiceProvider.GetRequiredService<IRectangleRepository>();
            var rectangles = await repository.FindMatchingRectanglesAsync(coordinate.X, coordinate.Y);
            return new(coordinate, rectangles);
        }
    }

    private RectangleModel MapToRectangleModel(Rectangle rectangle)
    {
        return new RectangleModel(
            Id: rectangle.Id,
            X1: rectangle.X1,
            Y1: rectangle.Y1,
            X2: rectangle.X2,
            Y2: rectangle.Y2);
    }
}
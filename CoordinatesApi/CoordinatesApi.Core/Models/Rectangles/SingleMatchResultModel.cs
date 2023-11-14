using System.Collections.Immutable;

namespace CoordinatesApi.Core.Models.Rectangles;

public sealed record SingleMatchResultModel(
    CoordinateModel Coordinate,
    IImmutableList<RectangleModel> Rectangles);
using System.Collections.Immutable;

namespace CoordinatesApi.Core.Models;

public sealed record SingleMatchResultModel(
    CoordinateModel Coordinate,
    IImmutableList<RectangleModel> Rectangles);
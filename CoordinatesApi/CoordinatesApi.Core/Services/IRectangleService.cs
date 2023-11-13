using System.Collections.Immutable;
using CoordinatesApi.Core.Models;

namespace CoordinatesApi.Core.Services;

public interface IRectangleService
{
    Task<MatchResultModel> MatchCoordinatesAsync(IImmutableList<CoordinateModel> coordinates);
}
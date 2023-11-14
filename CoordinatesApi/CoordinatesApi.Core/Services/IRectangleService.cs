using System.Collections.Immutable;
using System.Threading.Tasks;
using CoordinatesApi.Core.Models;
using CoordinatesApi.Core.Models.Rectangles;

namespace CoordinatesApi.Core.Services;

public interface IRectangleService
{
    Task<MatchResultModel> MatchCoordinatesAsync(IImmutableList<CoordinateModel> coordinates);
}
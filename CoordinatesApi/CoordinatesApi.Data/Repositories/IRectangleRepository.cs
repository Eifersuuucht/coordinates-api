using System.Collections.Immutable;
using System.Threading.Tasks;
using CoordinatesApi.Data.Entities;

namespace CoordinatesApi.Data.Repositories;

public interface IRectangleRepository
{
    Task<IImmutableList<Rectangle>> FindMatchingRectanglesAsync(int x, int y);
}
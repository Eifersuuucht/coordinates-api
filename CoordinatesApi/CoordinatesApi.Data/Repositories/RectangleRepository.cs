using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using CoordinatesApi.Data.Contexts;
using CoordinatesApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoordinatesApi.Data.Repositories;

public class RectangleRepository : IRectangleRepository
{
    private readonly AppDbContext _dbContext;

    public RectangleRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IImmutableList<Rectangle>> FindMatchingRectanglesAsync(int x, int y)
    {
        var rectangles = await _dbContext.Rectangles
            .Where(r => x >= r.X1 && x <= r.X2 && 
                        y >= r.Y1 && y <= r.Y2)
            .ToListAsync();

        return rectangles.ToImmutableList();
    }
}
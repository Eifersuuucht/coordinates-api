using System.Threading.Tasks;
using CoordinatesApi.Data.Contexts;
using CoordinatesApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoordinatesApi.Data.Repositories;

public sealed class UserRepository : IUserRepository
{
    private readonly AppDbContext _dbContext;

    public UserRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task CreateUserAsync(User user)
    {
        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
    }
    
    public Task<User?> FindByLoginAndPasswordAsync(string login, string password)
    {
        return _dbContext.Users
            .FirstOrDefaultAsync(x => x.Login == login && x.Password == password);
    }
}
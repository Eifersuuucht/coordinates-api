using System.Threading.Tasks;
using CoordinatesApi.Data.Entities;

namespace CoordinatesApi.Data.Repositories;

public interface IUserRepository
{
    Task CreateUserAsync(User user);
    Task<User?> FindByLoginAndPasswordAsync(string login, string password);
}
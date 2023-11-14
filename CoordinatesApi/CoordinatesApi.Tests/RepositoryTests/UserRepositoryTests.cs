using CoordinatesApi.Data.Contexts;
using CoordinatesApi.Data.Entities;
using CoordinatesApi.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CoordinatesApi.Tests.RepositoryTests;

[TestClass]
public class UserRepositoryTests
{
    private AppDbContext _dbContext;
    private UserRepository _userRepository;
    private DbContextOptions<AppDbContext> _options;

    [TestInitialize]
    public void SetUp()
    {
        _options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _dbContext = new AppDbContext(_options);
        _userRepository = new UserRepository(_dbContext);

        SeedDatabase();
    }

    private void SeedDatabase()
    {
        var users = new List<User>
        {
            new User { Login = "user1", Password = "password1" },
            new User { Login = "user2", Password = "password2" },
        };

        _dbContext.Users.AddRange(users);
        _dbContext.SaveChanges();
    }

    [TestMethod]
    public async Task CreateUserAsync_ShouldAddUser()
    {
        var newUser = new User { Login = "newUser", Password = "newPassword" };

        await _userRepository.CreateUserAsync(newUser);

        var addedUser = await _dbContext.Users.FirstOrDefaultAsync(u => u.Login == "newUser");
        Assert.IsNotNull(addedUser);
        Assert.AreEqual("newPassword", addedUser.Password);
    }

    [TestMethod]
    public async Task FindByLoginAndPasswordAsync_ShouldReturnUser_WhenCredentialsMatch()
    {
        var user = await _userRepository.FindByLoginAndPasswordAsync("user1", "password1");

        Assert.IsNotNull(user);
        Assert.AreEqual("user1", user.Login);
    }

    [TestMethod]
    public async Task FindByLoginAndPasswordAsync_ShouldReturnNull_WhenCredentialsDoNotMatch()
    {
        var user = await _userRepository.FindByLoginAndPasswordAsync("user1", "incorrectPassword");

        Assert.IsNull(user);
    }

    [TestCleanup]
    public void CleanUp()
    {
        _dbContext.Dispose();
    }
}

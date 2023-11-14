using CoordinatesApi.Core.Models.Auth;
using CoordinatesApi.Core.Services;
using CoordinatesApi.Data.Entities;
using CoordinatesApi.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Moq;

namespace CoordinatesApi.Tests.ServiceTests;

[TestClass]
public class UserServiceTests
{
    private Mock<IUserRepository> _mockUserRepository;
    private Mock<IConfiguration> _mockConfiguration;
    private UserService _userService;

    [TestInitialize]
    public void SetUp()
    {
        _mockUserRepository = new Mock<IUserRepository>();
        _mockConfiguration = new Mock<IConfiguration>();
        _userService = new UserService(_mockConfiguration.Object, _mockUserRepository.Object);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public async Task CreateUserAsync_ShouldThrowException_WhenPasswordsIsNotLongEnough()
    {
        var registerModel = new RegisterModel(
            Login: "user1",
            Password: "pass1",
            RepeatPassword: "pass1234");

        await _userService.CreateUserAsync(registerModel);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public async Task CreateUserAsync_ShouldThrowException_WhenPasswordsDoNotMatch()
    {
        var registerModel = new RegisterModel(
            Login: "user1",
            Password: "pass123",
            RepeatPassword: "pass1234");

        await _userService.CreateUserAsync(registerModel);
    }

    [TestMethod]
    public async Task CreateUserAsync_ShouldCallCreateUser_WhenValidModel()
    {
        var registerModel = new RegisterModel(
            Login: "user1",
            Password: "pass123",
            RepeatPassword: "pass123");
        _mockConfiguration.Setup(c => c["SecretKey"]).Returns("SomeSecretKey");

        await _userService.CreateUserAsync(registerModel);

        _mockUserRepository.Verify(r => r.CreateUserAsync(It.IsAny<User>()), Times.Once);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public async Task ValidateCredentialsAsync_ShouldThrowException_WhenUserNotFound()
    {
        var loginModel = new LoginModel(
            Login: "user1",
            Password: "pass123");
        
        _mockConfiguration.Setup(c => c["SecretKey"]).Returns("SomeSecretKey");
        _mockUserRepository.Setup(r => r.FindByLoginAndPasswordAsync(It.IsAny<string>(), It.IsAny<string>()))
            .ReturnsAsync((User)null);

        await _userService.ValidateCredentialsAsync(loginModel);
    }
}
using System;
using System.Threading.Tasks;
using CoordinatesApi.Core.Models.Auth;
using CoordinatesApi.Data.Entities;
using CoordinatesApi.Data.Repositories;
using CoordinatesApi.Shared.Extensions;
using Microsoft.Extensions.Configuration;

namespace CoordinatesApi.Core.Services;

public sealed class UserService : IUserService
{
    private readonly IConfiguration _configuration;
    private readonly IUserRepository _userRepository;

    public UserService(IConfiguration configuration, IUserRepository userRepository)
    {
        _configuration = configuration;
        _userRepository = userRepository;
    }

    private const int MinimumPasswordLength = 6;
    
    public Task CreateUserAsync(RegisterModel registerModel)
    {
        ValidateRegisterModel(registerModel);

        var newUser = new User
        {
            Login = registerModel.Login,
            Password = registerModel.Password.Encrypt(_configuration["SecretKey"])
        };

        return _userRepository.CreateUserAsync(newUser);
    }

    public async Task ValidateCredentialsAsync(LoginModel loginModel)
    {
        ValidateLoginModel(loginModel);

        var encryptedPassword = loginModel.Password.Encrypt(_configuration["SecretKey"]);
        var foundUser = await _userRepository.FindByLoginAndPasswordAsync(loginModel.Login, encryptedPassword);

        if (foundUser is null)
        {
            throw new Exception();
        }
    }

    private void ValidateRegisterModel(RegisterModel registerModel)
    {
        if (string.IsNullOrEmpty(registerModel.Login)
            || string.IsNullOrEmpty(registerModel.Password))
        {
            throw new Exception("Login and password cannot be empty.");
        }

        if (registerModel.Password != registerModel.RepeatPassword)
        {
            throw new Exception("Password and repeat password should be the same");
        }

        if (registerModel.Password.Length < MinimumPasswordLength)
        {
            throw new Exception($"Password should have at least {MinimumPasswordLength} symbols.");
        }
    }
    
    

    private void ValidateLoginModel(LoginModel loginModel)
    {
        if (string.IsNullOrEmpty(loginModel.Login)
            || string.IsNullOrEmpty(loginModel.Password))
        {
            throw new Exception("Login and password cannot be empty.");
        }
    }
}
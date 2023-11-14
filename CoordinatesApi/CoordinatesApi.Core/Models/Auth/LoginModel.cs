namespace CoordinatesApi.Core.Models.Auth;

public sealed record LoginModel(
    string Login,
    string Password);
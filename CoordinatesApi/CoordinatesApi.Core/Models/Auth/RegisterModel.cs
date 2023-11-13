namespace CoordinatesApi.Core.Models.Auth;

public record RegisterModel(
    string Login,
    string Password,
    string RepeatPassword);
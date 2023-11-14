namespace CoordinatesApi.Core.Models.Auth;

public sealed record RegisterModel(
    string Login,
    string Password,
    string RepeatPassword);
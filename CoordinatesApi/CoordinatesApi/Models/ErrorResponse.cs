namespace CoordinatesApi.WebApi.Models;

internal sealed record ErrorResponse(
    int StatusCode,
    string Message,
    string Details);
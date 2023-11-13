namespace CoordinatesApi.WebApi.Models;

public record ErrorResponse(
    int StatusCode,
    string Message,
    string Details);
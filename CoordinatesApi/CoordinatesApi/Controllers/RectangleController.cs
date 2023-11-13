﻿using System.Collections.Immutable;
using CoordinatesApi.Core.Models;
using CoordinatesApi.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoordinatesApi.WebApi.Controllers;

[ApiController]
public class RectangleController : ControllerBase
{
    private readonly IRectangleService _rectangleService;

    public RectangleController(IRectangleService rectangleService)
    {
        _rectangleService = rectangleService;
    }
    
    [HttpPost("api/v1/rectangles/match-coordinates")]
    public async Task<IActionResult> MatchCoordinates([FromBody] IImmutableList<CoordinateModel> coordinates)
    {
        var matchedRectangles = await _rectangleService.MatchCoordinatesAsync(coordinates);
        return Ok(matchedRectangles);
    }
}
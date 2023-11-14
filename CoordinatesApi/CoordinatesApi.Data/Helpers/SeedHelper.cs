using System;
using System.Collections.Generic;
using CoordinatesApi.Data.Entities;

namespace CoordinatesApi.Data.Helpers;

public class SeedHelper
{
    public static List<Rectangle> GetSeededRectangles()
    {
        var random = new Random();
        var rectangles = new List<Rectangle>();

        for (int i = 0; i < 200; i++)
        {
            int x1 = random.Next(0, 100);
            int y1 = random.Next(0, 100);
            int x2 = random.Next(x1, x1 + 50);
            int y2 = random.Next(y1, y1 + 50);

            var rectangle = new Rectangle
            {
                Id = i + 1,
                X1 = x1,
                Y1 = y1,
                X2 = x2,
                Y2 = y2
            };
            
            rectangles.Add(rectangle);
        }

        return rectangles;
    }
}
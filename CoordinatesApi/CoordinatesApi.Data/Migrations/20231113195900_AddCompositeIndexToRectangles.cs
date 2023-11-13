using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoordinatesApi.Data.Migrations
{
    public partial class AddCompositeIndexToRectangles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 19, 67, 42, 47 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 32, 55, 54, 88 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 99, 108, 85, 98 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 46, 61, 16, 29 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 70, 103, 25, 68 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 63, 67, 50, 58 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 15, 34, 76, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "X1", "X2", "Y2" },
                values: new object[] { 88, 95, 113 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 35, 81, 14, 44 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 102, 62, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "X1", "X2", "Y1" },
                values: new object[] { 94, 119, 40 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 49, 57, 67, 112 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 68, 93, 53, 98 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 49, 74, 59, 88 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 45, 73, 38, 61 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 10, 47, 18, 21 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 72, 94, 72, 121 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 48, 56, 83, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 73, 89, 58, 62 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 69, 101, 12, 61 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 82, 88, 52, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 20, 39, 71, 103 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 61, 79, 52, 72 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 36, 88, 135 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 7, 33, 71, 107 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 40, 75, 61, 73 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 2, 30, 11, 43 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 62, 73, 56, 63 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 97, 100, 88, 119 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 99, 129, 58, 77 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 48, 70, 90, 125 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 82, 130, 1, 20 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 90, 98, 50, 62 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 59, 65, 50, 98 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 48, 90, 42, 48 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 46, 67, 7, 55 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 13, 22, 36, 42 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 77, 79, 42, 82 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 46, 65, 14, 21 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 34, 46, 52, 60 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 42, 86, 97, 111 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 79, 51, 99 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 39, 72, 84, 104 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 93, 95, 89, 107 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 31, 46, 73, 112 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 81, 105, 58, 104 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 82, 122, 48, 82 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 2, 23, 0, 18 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 96, 140, 6, 35 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 77, 97, 88, 98 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 4, 5, 80, 124 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 54, 67, 31, 54 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 41, 25, 43 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 29, 48, 83, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 75, 116, 73, 115 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 63, 74, 72, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 41, 72, 87, 122 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 67, 87, 33, 69 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 65, 65, 75, 116 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 53, 101, 91, 125 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 69, 80, 70, 82 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 69, 105, 57, 66 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 3, 14, 66, 68 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 39, 42, 98, 110 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 19, 33, 21, 58 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 71, 98, 34, 68 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 18, 26, 38, 38 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 87, 127, 87, 136 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 49, 92, 9, 26 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 52, 72, 18, 23 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 54, 60, 13, 26 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 90, 7, 17 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 40, 62, 41, 86 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 46, 86, 61, 68 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 71, 118, 24, 39 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 123, 11, 41 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 63, 97, 37, 46 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 4, 49, 66, 76 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 31, 31, 8, 44 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 63, 86, 53, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 20, 37, 84, 126 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 3, 38, 91, 138 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 30, 77, 16, 51 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 79, 104, 60, 78 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 99, 137, 10, 40 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 89, 93, 32, 66 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 51, 53, 26, 66 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 43, 54, 22, 35 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 12, 22, 14, 46 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 40, 88, 26, 53 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 85, 94, 11, 27 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 1, 22, 56, 81 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "X1", "X2", "Y2" },
                values: new object[] { 79, 102, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 1, 31, 47, 55 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "X1", "X2", "Y1" },
                values: new object[] { 29, 71, 20 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 17, 25, 36, 73 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 87, 89, 83, 103 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 74, 84, 70, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 105, 9, 50 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 70, 103, 22, 60 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 45, 79, 75, 97 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 23, 31, 13, 14 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 72, 86, 43, 67 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 85, 102, 46, 88 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 95, 113, 29, 51 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "X2", "Y1", "Y2" },
                values: new object[] { 105, 52, 90 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 87, 46, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 17, 57, 47, 50 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 34, 40, 79, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 59, 68, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 45, 89, 57, 61 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 70, 84, 97, 141 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 81, 95, 85, 112 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 60, 92, 112 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "X1", "Y1", "Y2" },
                values: new object[] { 59, 50, 81 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 65, 90, 22, 23 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 58, 85, 61, 69 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 28, 58, 74, 122 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 56, 73, 65, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 72, 72, 15, 38 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 105, 21, 46 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 43, 52, 63, 68 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 20, 58, 22, 34 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 75, 105, 73, 76 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 69, 101, 72, 89 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 81, 92, 68, 83 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 50, 97, 73, 86 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 23, 29, 70, 108 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 31, 38, 31, 71 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 35, 68, 83, 108 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 65, 69, 88, 126 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 29, 42, 26, 29 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 23, 54, 18, 54 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 48, 86, 96, 135 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 65, 94, 61, 62 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 91, 138, 19, 60 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 35, 44, 80, 123 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 63, 69, 70, 86 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 89, 123, 80, 106 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 76, 83, 57, 69 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 87, 136, 37, 79 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 114, 83, 102 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "X1", "X2", "Y1" },
                values: new object[] { 88, 97, 0 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 32, 63, 30, 74 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 39, 79, 89, 126 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 95, 105, 11, 18 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 27, 47, 12, 56 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 37, 76, 60, 104 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 20, 64, 93, 111 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 74, 115, 62, 87 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 46, 54, 13, 43 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 35, 65, 27, 52 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 41, 88, 41, 45 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 7, 17, 51, 96 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 99, 122, 18, 56 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 32, 59, 36, 83 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 40, 69, 7, 47 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 7, 11, 85, 119 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 57, 47, 92 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 85, 118, 62, 103 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 9, 34, 24, 56 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 2, 25, 13, 55 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 76, 87, 86, 122 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 33, 56, 55, 56 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 35, 57, 84, 126 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 72, 75, 121 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 25, 59, 18, 18 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 22, 38, 1, 43 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 75, 87, 58, 102 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 51, 70, 36, 42 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 6, 34, 79, 124 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 56, 58, 91, 121 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 95, 97, 22, 55 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 80, 90, 98, 131 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 53, 79, 58, 73 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 20, 34, 5, 21 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 40, 58, 91, 139 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 18, 56, 96, 142 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 122, 30, 66 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 60, 62, 36, 62 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "X2", "Y1", "Y2" },
                values: new object[] { 56, 12, 32 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 79, 79, 29, 65 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 65, 105, 35, 58 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 21, 49, 11, 32 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 28, 47, 4, 9 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 60, 67, 78, 87 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 58, 65, 92, 120 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 21, 23, 24, 66 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 6, 47, 23, 46 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 80, 94, 77, 85 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 29, 31, 62, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 15, 32, 58, 107 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 11, 28, 18, 47 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 63, 90, 39, 72 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 95, 121, 70, 102 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 60, 92, 14, 54 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 118, 30, 51 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 73, 87, 123 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 93, 105, 26, 41 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 98, 120, 47, 66 });

            migrationBuilder.CreateIndex(
                name: "IX_Rectangles_X1_Y1_X2_Y2",
                table: "Rectangles",
                columns: new[] { "X1", "Y1", "X2", "Y2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rectangles_X1_Y1_X2_Y2",
                table: "Rectangles");

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 26, 29, 6, 42 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 93, 112, 71, 118 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 71, 111, 81, 104 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 52, 74, 0, 32 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 56, 95, 43, 49 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 61, 66, 91, 120 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 19, 26, 83, 124 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "X1", "X2", "Y2" },
                values: new object[] { 77, 117, 85 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 67, 71, 62, 90 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 50, 66, 79, 94 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "X1", "X2", "Y1" },
                values: new object[] { 4, 52, 62 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 17, 93, 123 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 35, 72, 69, 111 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 75, 83, 53, 54 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 48, 86, 56, 85 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 42, 88, 77, 90 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 57, 65, 89 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 72, 75, 19, 34 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 44, 61, 39, 61 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 45, 77, 24, 24 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 41, 48, 93, 138 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 29, 33, 47, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 88, 128, 56, 88 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 25, 69, 33, 69 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 76, 89, 18, 47 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 16, 53, 49, 96 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 28, 64, 0, 24 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 97, 100, 4, 12 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 95, 111, 64, 104 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 50, 91, 99 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 10, 54, 87, 93 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 11, 27, 67, 103 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 60, 92, 74, 90 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 31, 68, 5, 23 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 123, 23, 49 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 64, 96, 80, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 4, 6, 20, 50 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 119, 6, 53 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 68, 68, 99 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 75, 98, 67, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 54, 103, 53, 102 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 69, 110, 22, 42 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 47, 78, 2, 9 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 23, 25, 22, 38 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 81, 26, 43 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 90, 137, 44, 55 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 76, 125, 94, 97 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 38, 50, 59, 88 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 75, 113, 38, 73 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 66, 80, 29, 60 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 67, 91, 55, 104 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 35, 42, 47 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 1, 11, 48, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 45, 56, 89, 109 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 55, 95, 15, 31 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 30, 44, 47, 68 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 78, 79, 94, 121 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 80, 107, 64, 104 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 49, 62, 33, 64 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 72, 97, 98, 123 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 4, 37, 37, 77 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 35, 62, 83, 98 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 42, 88, 31, 48 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 63, 88, 72, 78 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 65, 77, 12, 54 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 91, 104, 35, 57 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 70, 79, 42, 65 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 62, 94, 26, 53 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 81, 115, 11, 34 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 18, 33, 69, 88 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 20, 33, 21, 54 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 90, 110, 64, 81 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 17, 48, 15, 31 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 63, 104, 9, 16 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 10, 20, 73, 106 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 97, 99, 76, 99 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 94, 107, 75, 91 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 82, 99, 9, 44 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 85, 90, 84, 110 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 71, 72, 21, 26 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 82, 83, 71, 76 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 87, 28, 41 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 66, 110, 56, 96 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 17, 57, 94, 138 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 92, 113, 8, 18 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 24, 40, 50, 64 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 59, 90, 34, 34 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 66, 107, 64, 107 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 78, 85, 26, 56 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 32, 80, 3, 47 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 21, 59, 30, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 2, 50, 96, 117 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "X1", "X2", "Y2" },
                values: new object[] { 10, 29, 52 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 35, 62, 25, 33 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "X1", "X2", "Y1" },
                values: new object[] { 62, 77, 66 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 9, 15, 6, 11 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 58, 79, 64, 89 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 69, 117, 13, 60 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 41, 64, 48, 91 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 13, 27, 68, 90 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 66, 85, 16, 53 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 78, 105, 28, 32 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 90, 137, 23, 49 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 7, 17, 61, 64 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 21, 51, 68, 94 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "X2", "Y1", "Y2" },
                values: new object[] { 83, 44, 89 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 9, 9, 57, 57 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 98, 139, 26, 44 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 23, 24, 64, 67 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 11, 22, 31, 34 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 28, 50, 5, 35 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 93, 123, 14, 22 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 62, 110, 79, 90 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 7, 26, 64, 75 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "X1", "Y1", "Y2" },
                values: new object[] { 31, 1, 9 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 79, 88, 80, 129 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 42, 84, 56, 81 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 111, 33, 42 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 23, 43, 99, 119 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 67, 111, 88, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 30, 57, 71, 83 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 41, 35, 43 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 32, 70, 97, 137 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 78, 90, 8, 40 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 16, 39, 98, 109 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 62, 83, 79, 103 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 26, 44, 37, 67 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 84, 96, 55, 83 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 8, 30, 17, 58 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 96, 126, 51, 87 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 50, 90, 61, 64 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 44, 32, 60 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 68, 114, 94, 102 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 32, 56, 87, 88 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 85, 105, 62, 107 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 84, 132, 72, 87 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 32, 80, 0, 40 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 98, 147, 76, 115 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 24, 72, 117 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 35, 40, 96, 108 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 27, 27, 23, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 6, 43, 15, 33 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "X1", "X2", "Y1" },
                values: new object[] { 48, 88, 9 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 130, 40, 52 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 26, 85, 111 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 72, 80, 49, 95 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 32, 52, 51, 78 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 62, 67, 12, 36 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 40, 55, 34, 49 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 15, 44, 45, 85 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 52, 52, 72, 111 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 111, 15, 18 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 96, 135, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 42, 68, 79, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 0, 48, 42, 91 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 9, 10, 78, 87 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 48, 79, 74, 99 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 77, 95, 69, 107 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 53, 95, 57, 81 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 41, 77, 20, 54 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 70, 116, 91, 107 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 89, 114, 26, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 12, 51, 11, 40 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 91, 114, 98, 128 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 64, 81, 53, 78 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 9, 48, 31, 54 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 31, 64, 42, 53 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 90, 93, 76, 123 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 69, 81, 78, 98 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 70, 83, 25, 56 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 92, 132, 21, 52 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 30, 31, 17, 56 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 4, 20, 69, 90 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 31, 48, 91, 139 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 25, 71, 40, 72 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 5, 18, 68, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 74, 104, 56, 89 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 68, 116, 44, 77 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 10, 55, 88, 97 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 24, 72, 53, 81 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "X2", "Y1", "Y2" },
                values: new object[] { 45, 79, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 54, 77, 51, 52 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 50, 76, 18, 53 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 62, 72, 0, 39 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 93, 105, 57, 93 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 45, 51, 22, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 16, 18, 4, 33 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 33, 61, 64, 91 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 5, 21, 3, 52 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 77, 92, 24, 26 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 18, 22, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 53, 100, 47, 58 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 96, 144, 53, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 54, 96, 73, 112 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 40, 86, 26, 60 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 7, 42, 41, 76 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 93, 98, 23, 67 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 18, 32, 5, 34 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 73, 87, 1, 30 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 81, 100, 60, 92 });
        }
    }
}

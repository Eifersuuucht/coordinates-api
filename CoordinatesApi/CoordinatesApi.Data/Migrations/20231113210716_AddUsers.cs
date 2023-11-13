using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoordinatesApi.Data.Migrations
{
    public partial class AddUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 49, 79, 40, 72 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 59, 69, 27, 57 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 49, 82, 92, 97 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 19, 60, 21, 41 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 73, 102, 0, 18 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 24, 65, 26, 40 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 38, 40, 96, 126 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 2, 42, 79, 111 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 94, 112, 50, 96 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 73, 90, 26, 39 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 50, 89, 18, 47 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 9, 42, 3, 30 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 88, 115, 60, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 2, 6, 82, 124 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 98, 114, 53, 69 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 81, 118, 15, 52 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 76, 110, 12, 41 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 93, 128, 23, 64 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 47, 47, 75, 120 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 75, 106, 84, 124 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 68, 69, 21, 31 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 25, 49, 16, 57 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 15, 18, 13, 27 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "X1", "Y1", "Y2" },
                values: new object[] { 1, 18, 44 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 15, 52, 4, 15 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 48, 95, 62, 102 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 46, 93, 1, 14 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 37, 84, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 76, 120, 62, 81 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 69, 117, 21, 58 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 91, 92, 6, 42 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 88, 93, 23, 63 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 30, 55, 4, 13 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 62, 93, 31, 43 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 45, 70, 81, 114 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 2, 18, 53, 69 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 84, 116, 10, 57 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 80, 91, 52, 65 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 57, 73, 96, 105 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 87, 129, 39, 77 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 71, 83, 16, 19 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 67, 77, 26, 30 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 85, 86, 66, 96 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 54, 79, 52, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 57, 94, 13, 20 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 112, 67, 103 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 25, 47, 79, 113 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 58, 85, 91, 102 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 59, 68, 81, 126 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 64, 104, 75, 119 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 47, 85, 45, 59 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 79, 96, 18, 57 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 9, 40, 2, 2 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 99, 147, 37, 61 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 61, 110, 10, 56 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 107, 70, 92 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 87, 93, 91, 133 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 90, 124, 28, 44 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 10, 12, 62, 111 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 64, 76, 61, 93 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 23, 48, 36, 53 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 96, 130, 33, 59 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 55, 73, 81, 110 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 78, 112, 13, 40 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 66, 86, 45, 47 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 40, 68, 58, 93 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 4, 18, 39, 73 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 40, 82, 36, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 89, 89, 56, 99 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 7, 54, 89, 105 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 75, 95, 77, 109 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 49, 96, 52, 76 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 29, 32, 8, 57 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 57, 60, 6, 33 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 32, 52, 87, 128 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 28, 37, 4, 20 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 94, 108, 20, 27 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 16, 48, 41, 50 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 97, 119, 97, 112 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 23, 66, 30, 74 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 43, 81, 9, 13 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 10, 32, 21, 51 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 41, 54, 51, 90 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 78, 114, 34, 79 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 36, 56, 5, 16 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "X2", "Y1", "Y2" },
                values: new object[] { 106, 19, 31 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 0, 12, 82, 130 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 53, 91, 36, 85 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 3, 9, 24, 34 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 18, 21, 11, 18 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 69, 72, 49, 51 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 8, 38, 48, 56 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "X1", "X2", "Y2" },
                values: new object[] { 10, 58, 55 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "X2", "Y1", "Y2" },
                values: new object[] { 12, 65, 68 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 19, 30, 83, 110 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 94, 116, 77, 126 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 26, 50, 34, 74 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 22, 59, 10, 52 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 76, 108, 4, 19 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "X1", "X2", "Y2" },
                values: new object[] { 7, 56, 30 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 16, 40, 36, 59 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 56, 89, 85, 95 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 84, 111, 44, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 58, 85, 53, 98 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 22, 43, 33, 69 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 82, 94, 82, 103 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 25, 31, 47 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 34, 42, 80, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 79, 88, 54, 85 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 39, 64, 10, 59 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 10, 38, 62, 91 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 91, 28, 48 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 8, 37, 78, 99 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 66, 72, 98, 133 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 101, 36, 51 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 71, 76, 25, 29 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 47, 52, 94, 126 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 89, 101, 44, 59 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 45, 94, 88, 134 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 38, 40, 46, 78 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 97, 141, 38, 76 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 84, 116, 71, 96 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 79, 93, 3, 36 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 23, 31, 37, 64 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 26, 40, 69, 99 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 31, 64, 42, 54 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 77, 122, 66, 115 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 82, 101, 41, 55 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 90, 104, 39, 41 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 39, 69, 113 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 81, 83, 80, 100 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 14, 16, 44, 53 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 58, 58, 45, 79 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 103, 44, 71 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 6, 28, 86, 97 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 80, 121, 10, 55 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 93, 113, 77, 104 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 33, 72, 15, 58 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 3, 20, 55, 101 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 71, 89, 45, 91 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 29, 51, 1, 18 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 16, 41, 73, 101 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 92, 99, 3, 18 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 72, 83, 20, 43 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 13, 42, 33, 50 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 85, 115, 84, 84 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "X2", "Y1", "Y2" },
                values: new object[] { 43, 16, 26 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 21, 36, 79, 111 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 6, 23, 69, 113 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 39, 48, 93, 130 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 26, 32, 19, 28 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 74, 102, 90, 139 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 45, 67, 49, 50 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 0, 15, 9, 25 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 17, 65, 81, 112 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 44, 81, 0, 32 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 7, 14, 48, 59 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 110, 18, 22 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 93, 118, 38, 53 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 84, 89, 44, 62 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 96, 114, 91, 109 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 97, 107, 20, 51 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 32, 60, 23, 33 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 73, 116, 41, 70 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 6, 32, 72, 98 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 85, 97, 67, 101 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 57, 79, 74, 99 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 44, 69, 5, 37 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 38, 80, 22, 61 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 65, 67, 92, 105 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 4, 6, 54, 56 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 72, 75, 68, 68 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 94, 130, 1, 35 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 85, 36, 76 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 74, 103, 99, 101 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 68, 86, 15, 43 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 99, 122, 54, 72 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 39, 86, 86, 87 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 22, 48, 69, 90 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "X1", "X2", "Y2" },
                values: new object[] { 27, 69, 66 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 56, 59, 28, 29 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 40, 77, 72, 118 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 86, 125, 73, 89 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 60, 74, 23, 72 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 91, 91, 0, 33 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 38, 80, 42, 81 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 35, 71, 57, 59 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 83, 110, 28, 28 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 21, 29, 14, 53 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 49, 49, 96, 113 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 88, 95, 42, 60 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 63, 67, 40, 74 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 54, 86, 42, 60 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 52, 69, 94, 137 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 80, 96, 69, 87 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 12, 35, 65, 108 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 49, 66, 21, 38 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 55, 88, 22, 35 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 89, 119, 34, 65 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 16, 32, 22, 56 });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Login",
                table: "Users",
                column: "Login",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 88, 95, 71, 113 });

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
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 94, 119, 40, 76 });

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
                columns: new[] { "X1", "Y1", "Y2" },
                values: new object[] { 14, 88, 135 });

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
                columns: new[] { "X2", "Y1", "Y2" },
                values: new object[] { 93, 32, 66 });

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
                columns: new[] { "X2", "Y1", "Y2" },
                values: new object[] { 31, 47, 55 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 29, 71, 20, 67 });

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
                columns: new[] { "X1", "X2", "Y2" },
                values: new object[] { 70, 103, 60 });

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
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 59, 105, 52, 90 });

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
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 59, 78, 50, 81 });

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
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 88, 97, 0, 49 });

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
                columns: new[] { "X2", "Y1", "Y2" },
                values: new object[] { 47, 12, 56 });

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
                columns: new[] { "X1", "X2", "Y2" },
                values: new object[] { 60, 62, 62 });

            migrationBuilder.UpdateData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "X1", "X2", "Y1", "Y2" },
                values: new object[] { 39, 56, 12, 32 });

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
        }
    }
}

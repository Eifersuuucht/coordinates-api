using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoordinatesApi.Data.Migrations
{
    public partial class SeedRectangles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rectangles",
                columns: new[] { "Id", "X1", "X2", "Y1", "Y2" },
                values: new object[,]
                {
                    { 1, 26, 29, 6, 42 },
                    { 2, 93, 112, 71, 118 },
                    { 3, 71, 111, 81, 104 },
                    { 4, 52, 74, 0, 32 },
                    { 5, 56, 95, 43, 49 },
                    { 6, 61, 66, 91, 120 },
                    { 7, 19, 26, 83, 124 },
                    { 8, 77, 117, 71, 85 },
                    { 9, 67, 71, 62, 90 },
                    { 10, 50, 66, 79, 94 },
                    { 11, 4, 52, 62, 76 },
                    { 12, 14, 17, 93, 123 },
                    { 13, 35, 72, 69, 111 },
                    { 14, 75, 83, 53, 54 },
                    { 15, 48, 86, 56, 85 },
                    { 16, 42, 88, 77, 90 },
                    { 17, 36, 57, 65, 89 },
                    { 18, 72, 75, 19, 34 },
                    { 19, 44, 61, 39, 61 },
                    { 20, 45, 77, 24, 24 },
                    { 21, 41, 48, 93, 138 },
                    { 22, 29, 33, 47, 70 },
                    { 23, 88, 128, 56, 88 },
                    { 24, 25, 69, 33, 69 },
                    { 25, 76, 89, 18, 47 },
                    { 26, 16, 53, 49, 96 },
                    { 27, 28, 64, 0, 24 },
                    { 28, 97, 100, 4, 12 },
                    { 29, 95, 111, 64, 104 },
                    { 30, 36, 50, 91, 99 },
                    { 31, 10, 54, 87, 93 },
                    { 32, 11, 27, 67, 103 },
                    { 33, 60, 92, 74, 90 },
                    { 34, 31, 68, 5, 23 },
                    { 35, 83, 123, 23, 49 },
                    { 36, 64, 96, 80, 100 },
                    { 37, 4, 6, 20, 50 },
                    { 38, 86, 119, 6, 53 },
                    { 39, 36, 68, 68, 99 },
                    { 40, 75, 98, 67, 84 },
                    { 41, 54, 103, 53, 102 },
                    { 42, 69, 110, 22, 42 }
                });

            migrationBuilder.InsertData(
                table: "Rectangles",
                columns: new[] { "Id", "X1", "X2", "Y1", "Y2" },
                values: new object[,]
                {
                    { 43, 47, 78, 2, 9 },
                    { 44, 23, 25, 22, 38 },
                    { 45, 36, 81, 26, 43 },
                    { 46, 90, 137, 44, 55 },
                    { 47, 76, 125, 94, 97 },
                    { 48, 38, 50, 59, 88 },
                    { 49, 75, 113, 38, 73 },
                    { 50, 66, 80, 29, 60 },
                    { 51, 67, 91, 55, 104 },
                    { 52, 14, 35, 42, 47 },
                    { 53, 1, 11, 48, 70 },
                    { 54, 45, 56, 89, 109 },
                    { 55, 55, 95, 15, 31 },
                    { 56, 30, 44, 47, 68 },
                    { 57, 78, 79, 94, 121 },
                    { 58, 80, 107, 64, 104 },
                    { 59, 49, 62, 33, 64 },
                    { 60, 72, 97, 98, 123 },
                    { 61, 4, 37, 37, 77 },
                    { 62, 35, 62, 83, 98 },
                    { 63, 42, 88, 31, 48 },
                    { 64, 63, 88, 72, 78 },
                    { 65, 65, 77, 12, 54 },
                    { 66, 91, 104, 35, 57 },
                    { 67, 70, 79, 42, 65 },
                    { 68, 62, 94, 26, 53 },
                    { 69, 81, 115, 11, 34 },
                    { 70, 18, 33, 69, 88 },
                    { 71, 20, 33, 21, 54 },
                    { 72, 90, 110, 64, 81 },
                    { 73, 17, 48, 15, 31 },
                    { 74, 63, 104, 9, 16 },
                    { 75, 10, 20, 73, 106 },
                    { 76, 97, 99, 76, 99 },
                    { 77, 94, 107, 75, 91 },
                    { 78, 82, 99, 9, 44 },
                    { 79, 85, 90, 84, 110 },
                    { 80, 71, 72, 21, 26 },
                    { 81, 82, 83, 71, 76 },
                    { 82, 83, 87, 28, 41 },
                    { 83, 66, 110, 56, 96 },
                    { 84, 17, 57, 94, 138 }
                });

            migrationBuilder.InsertData(
                table: "Rectangles",
                columns: new[] { "Id", "X1", "X2", "Y1", "Y2" },
                values: new object[,]
                {
                    { 85, 92, 113, 8, 18 },
                    { 86, 24, 40, 50, 64 },
                    { 87, 59, 90, 34, 34 },
                    { 88, 66, 107, 64, 107 },
                    { 89, 78, 85, 26, 56 },
                    { 90, 32, 80, 3, 47 },
                    { 91, 21, 59, 30, 70 },
                    { 92, 2, 50, 96, 117 },
                    { 93, 10, 29, 51, 52 },
                    { 94, 35, 62, 25, 33 },
                    { 95, 62, 77, 66, 67 },
                    { 96, 9, 15, 6, 11 },
                    { 97, 58, 79, 64, 89 },
                    { 98, 69, 117, 13, 60 },
                    { 99, 41, 64, 48, 91 },
                    { 100, 13, 27, 68, 90 },
                    { 101, 66, 85, 16, 53 },
                    { 102, 78, 105, 28, 32 },
                    { 103, 90, 137, 23, 49 },
                    { 104, 7, 17, 61, 64 },
                    { 105, 21, 51, 68, 94 },
                    { 106, 59, 83, 44, 89 },
                    { 107, 9, 9, 57, 57 },
                    { 108, 98, 139, 26, 44 },
                    { 109, 23, 24, 64, 67 },
                    { 110, 11, 22, 31, 34 },
                    { 111, 28, 50, 5, 35 },
                    { 112, 93, 123, 14, 22 },
                    { 113, 62, 110, 79, 90 },
                    { 114, 7, 26, 64, 75 },
                    { 115, 31, 78, 1, 9 },
                    { 116, 79, 88, 80, 129 },
                    { 117, 42, 84, 56, 81 },
                    { 118, 86, 111, 33, 42 },
                    { 119, 23, 43, 99, 119 },
                    { 120, 67, 111, 88, 100 },
                    { 121, 30, 57, 71, 83 },
                    { 122, 14, 41, 35, 43 },
                    { 123, 32, 70, 97, 137 },
                    { 124, 78, 90, 8, 40 },
                    { 125, 16, 39, 98, 109 },
                    { 126, 62, 83, 79, 103 }
                });

            migrationBuilder.InsertData(
                table: "Rectangles",
                columns: new[] { "Id", "X1", "X2", "Y1", "Y2" },
                values: new object[,]
                {
                    { 127, 26, 44, 37, 67 },
                    { 128, 84, 96, 55, 83 },
                    { 129, 8, 30, 17, 58 },
                    { 130, 96, 126, 51, 87 },
                    { 131, 50, 90, 61, 64 },
                    { 132, 36, 44, 32, 60 },
                    { 133, 68, 114, 94, 102 },
                    { 134, 32, 56, 87, 88 },
                    { 135, 85, 105, 62, 107 },
                    { 136, 84, 132, 72, 87 },
                    { 137, 32, 80, 0, 40 },
                    { 138, 98, 147, 76, 115 },
                    { 139, 14, 24, 72, 117 },
                    { 140, 35, 40, 96, 108 },
                    { 141, 27, 27, 23, 70 },
                    { 142, 6, 43, 15, 33 },
                    { 143, 48, 88, 9, 49 },
                    { 144, 83, 130, 40, 52 },
                    { 145, 14, 26, 85, 111 },
                    { 146, 72, 80, 49, 95 },
                    { 147, 32, 52, 51, 78 },
                    { 148, 62, 67, 12, 36 },
                    { 149, 40, 55, 34, 49 },
                    { 150, 15, 44, 45, 85 },
                    { 151, 52, 52, 72, 111 },
                    { 152, 86, 111, 15, 18 },
                    { 153, 96, 135, 2, 6 },
                    { 154, 42, 68, 79, 100 },
                    { 155, 0, 48, 42, 91 },
                    { 156, 9, 10, 78, 87 },
                    { 157, 48, 79, 74, 99 },
                    { 158, 77, 95, 69, 107 },
                    { 159, 53, 95, 57, 81 },
                    { 160, 41, 77, 20, 54 },
                    { 161, 70, 116, 91, 107 },
                    { 162, 89, 114, 26, 70 },
                    { 163, 12, 51, 11, 40 },
                    { 164, 91, 114, 98, 128 },
                    { 165, 64, 81, 53, 78 },
                    { 166, 9, 48, 31, 54 },
                    { 167, 31, 64, 42, 53 },
                    { 168, 90, 93, 76, 123 }
                });

            migrationBuilder.InsertData(
                table: "Rectangles",
                columns: new[] { "Id", "X1", "X2", "Y1", "Y2" },
                values: new object[,]
                {
                    { 169, 69, 81, 78, 98 },
                    { 170, 70, 83, 25, 56 },
                    { 171, 92, 132, 21, 52 },
                    { 172, 30, 31, 17, 56 },
                    { 173, 4, 20, 69, 90 },
                    { 174, 31, 48, 91, 139 },
                    { 175, 25, 71, 40, 72 },
                    { 176, 5, 18, 68, 100 },
                    { 177, 74, 104, 56, 89 },
                    { 178, 68, 116, 44, 77 },
                    { 179, 10, 55, 88, 97 },
                    { 180, 24, 72, 53, 81 },
                    { 181, 39, 45, 79, 100 },
                    { 182, 54, 77, 51, 52 },
                    { 183, 50, 76, 18, 53 },
                    { 184, 62, 72, 0, 39 },
                    { 185, 93, 105, 57, 93 },
                    { 186, 45, 51, 22, 70 },
                    { 187, 16, 18, 4, 33 },
                    { 188, 33, 61, 64, 91 },
                    { 189, 5, 21, 3, 52 },
                    { 190, 77, 92, 24, 26 },
                    { 191, 18, 22, 3, 5 },
                    { 192, 53, 100, 47, 58 },
                    { 193, 96, 144, 53, 84 },
                    { 194, 54, 96, 73, 112 },
                    { 195, 40, 86, 26, 60 },
                    { 196, 7, 42, 41, 76 },
                    { 197, 93, 98, 23, 67 },
                    { 198, 18, 32, 5, 34 },
                    { 199, 73, 87, 1, 30 },
                    { 200, 81, 100, 60, 92 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Rectangles",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}

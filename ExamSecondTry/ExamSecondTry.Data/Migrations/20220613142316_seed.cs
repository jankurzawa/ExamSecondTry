using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamSecondTry.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Length", "Review", "Title" },
                values: new object[] { new Guid("4518ad4b-28fc-489f-9fd6-ac25a4b620bd"), "Martin Scorsese", 3.0, "average", "The Wolf Of Wall Street" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Length", "Review", "Title" },
                values: new object[] { new Guid("4a40dbfe-52f7-4d47-bfc1-7d7cb6146f2e"), "James Cameron", 3.1400000000000001, "Boring", "Titanic" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Length", "Review", "Title" },
                values: new object[] { new Guid("a77d0dbe-033a-449b-b661-57be85bcc471"), "James Cameron", 2.3999999999999999, "Nice", "Avatar" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4518ad4b-28fc-489f-9fd6-ac25a4b620bd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("4a40dbfe-52f7-4d47-bfc1-7d7cb6146f2e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("a77d0dbe-033a-449b-b661-57be85bcc471"));
        }
    }
}

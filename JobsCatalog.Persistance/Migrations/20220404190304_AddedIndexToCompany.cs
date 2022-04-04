using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsCatalog.Persistance.Migrations
{
    public partial class AddedIndexToCompany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 73, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 73, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 73, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 73, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 73, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 73, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 73, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 73, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 73, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 73, DateTimeKind.Unspecified).AddTicks(9960), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 76, DateTimeKind.Unspecified).AddTicks(5262), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 4, 19, 3, 4, 75, DateTimeKind.Unspecified).AddTicks(3243), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 802, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 802, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 802, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 802, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 802, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 802, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 802, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 802, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 802, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 802, DateTimeKind.Unspecified).AddTicks(6728), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 805, DateTimeKind.Unspecified).AddTicks(1575), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 4, 3, 14, 29, 23, 803, DateTimeKind.Unspecified).AddTicks(9699), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}

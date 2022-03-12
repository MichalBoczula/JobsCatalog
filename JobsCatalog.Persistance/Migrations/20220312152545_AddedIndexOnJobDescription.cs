using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsCatalog.Persistance.Migrations
{
    public partial class AddedIndexOnJobDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 165, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 165, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 165, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 165, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 165, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 165, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 165, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 165, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 165, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 165, DateTimeKind.Unspecified).AddTicks(770), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 167, DateTimeKind.Unspecified).AddTicks(6028), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 12, 15, 25, 45, 166, DateTimeKind.Unspecified).AddTicks(4036), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 924, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 924, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 924, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 924, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 924, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 924, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 924, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 924, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 924, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 924, DateTimeKind.Unspecified).AddTicks(1747), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 926, DateTimeKind.Unspecified).AddTicks(7194), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 2, 26, 13, 38, 59, 925, DateTimeKind.Unspecified).AddTicks(5113), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}

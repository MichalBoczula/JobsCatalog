using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsCatalog.Persistance.Migrations
{
    public partial class AddedVersionStampToAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VersionStamp",
                table: "JobOffers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VersionStamp",
                table: "JobDescriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VersionStamp",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VersionStamp",
                table: "JobOffers");

            migrationBuilder.DropColumn(
                name: "VersionStamp",
                table: "JobDescriptions");

            migrationBuilder.DropColumn(
                name: "VersionStamp",
                table: "Companies");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 635, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 635, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 635, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 635, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 635, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 635, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 635, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 635, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 635, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 635, DateTimeKind.Unspecified).AddTicks(9300), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 638, DateTimeKind.Unspecified).AddTicks(4352), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 3, 20, 15, 58, 45, 637, DateTimeKind.Unspecified).AddTicks(2446), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}

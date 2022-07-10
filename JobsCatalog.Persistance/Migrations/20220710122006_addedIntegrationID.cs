using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsCatalog.Persistance.Migrations
{
    public partial class addedIntegrationID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IntegrationId",
                table: "JobOffers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 401, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 401, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 401, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 401, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 401, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 401, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 401, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 401, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 401, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 401, DateTimeKind.Unspecified).AddTicks(5785), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobDescriptions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 404, DateTimeKind.Unspecified).AddTicks(1411), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "fdd87462-6915-4684-9577-05c26cbbfaf0", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "4d4470a7-ceb8-4a93-9284-7cd9056421d9", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "8707c094-8969-4207-ae6c-c41db2fa1303", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "a1cfd91a-629a-412a-87bf-c76b0b693e8c", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "19e1716f-0ae1-4a05-b043-6cbf47a10b94", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "7e926185-6819-476b-a7c1-4d84b5592e7b", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "71604576-ba3f-494c-b10d-0a444c9324f9", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "5ae8cf71-5170-485f-b4b8-82909779288f", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "601f72b9-9c93-472b-ae40-2da7016b79fe", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "be7e157f-fb2f-43c9-a075-b04cefc16874", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "153c59dd-cfff-4a6c-aff1-f30b4130a021", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "b82bca77-6097-4310-aa60-a8325e6e98ce", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "6aa3e64b-ea26-4961-ad88-d3bb738985cd", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "39d1b236-a265-4fcc-9612-4dbccfd725f6", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "JobOffers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "IntegrationId", "Modified" },
                values: new object[] { new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)), "184e2420-0fa8-4640-ab40-40945557c044", new DateTimeOffset(new DateTime(2022, 7, 10, 12, 20, 5, 402, DateTimeKind.Unspecified).AddTicks(9183), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IntegrationId",
                table: "JobOffers");

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
    }
}

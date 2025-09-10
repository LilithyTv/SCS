using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCS.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(2024, 11, 12));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateOnly(2024, 11, 13));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateOnly(2024, 11, 14));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateOnly(2024, 11, 15));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateOnly(2024, 11, 16));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateOnly(2024, 11, 22));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateOnly(2024, 11, 23));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateOnly(2024, 11, 24));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateOnly(2024, 11, 25));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateOnly(2024, 11, 26));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateOnly(2024, 11, 27));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateOnly(2024, 11, 28));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateOnly(2024, 11, 29));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateOnly(2024, 11, 30));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateOnly(2024, 12, 1));

            migrationBuilder.UpdateData(
                table: "CertificationSlots",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dates", "EndDate", "Name", "StartDate" },
                values: new object[] { "[\"2024-11-13\",\"2024-11-15\"]", new DateOnly(2024, 11, 16), "Sanctions", new DateOnly(2024, 11, 12) });

            migrationBuilder.UpdateData(
                table: "CertificationSlots",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dates", "EndDate", "Name", "StartDate" },
                values: new object[] { "[\"2024-11-23\",\"2024-11-26\",\"2024-11-28\"]", new DateOnly(2024, 12, 1), "C# Beginner", new DateOnly(2024, 11, 22) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateOnly(2024, 10, 31));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateOnly(2024, 11, 1));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateOnly(2024, 11, 2));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateOnly(2024, 11, 3));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateOnly(2024, 11, 4));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateOnly(2024, 11, 10));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateOnly(2024, 11, 11));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateOnly(2024, 11, 12));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateOnly(2024, 11, 13));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateOnly(2024, 11, 14));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateOnly(2024, 11, 15));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateOnly(2024, 11, 16));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateOnly(2024, 11, 17));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateOnly(2024, 11, 18));

            migrationBuilder.UpdateData(
                table: "CertificationDays",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateOnly(2024, 11, 19));

            migrationBuilder.UpdateData(
                table: "CertificationSlots",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Dates", "EndDate", "Name", "StartDate" },
                values: new object[] { "[\"2024-11-01\",\"2024-11-03\"]", new DateOnly(2024, 11, 4), "Slot1", new DateOnly(2024, 10, 31) });

            migrationBuilder.UpdateData(
                table: "CertificationSlots",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Dates", "EndDate", "Name", "StartDate" },
                values: new object[] { "[\"2024-11-11\",\"2024-11-14\",\"2024-11-16\"]", new DateOnly(2024, 11, 19), "Slot2", new DateOnly(2024, 11, 10) });
        }
    }
}

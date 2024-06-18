using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Migration.Migrations
{
    /// <inheritdoc />
    public partial class vilaTest2 : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SampleTable",
                newName: "Name_2");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCreate",
                table: "SampleTable",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreate",
                table: "SampleTable");

            migrationBuilder.RenameColumn(
                name: "Name_2",
                table: "SampleTable",
                newName: "Name");
        }
    }
}

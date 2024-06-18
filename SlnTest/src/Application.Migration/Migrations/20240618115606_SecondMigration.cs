using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Application.Migration.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SecondTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SampleTableId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecondTable_SampleTable_SampleTableId",
                        column: x => x.SampleTableId,
                        principalTable: "SampleTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SecondTable_Name",
                table: "SecondTable",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SecondTable_SampleTableId",
                table: "SecondTable",
                column: "SampleTableId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SecondTable");
        }
    }
}

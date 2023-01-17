using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blue.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(80)", maxLength: 80, nullable: false),
                    Telefone = table.Column<string>(type: "VARCHAR(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agenda");
        }
    }
}

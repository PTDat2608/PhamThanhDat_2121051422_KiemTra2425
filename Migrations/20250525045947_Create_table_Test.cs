using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PTD_Ktra.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_Test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    HoTen = table.Column<string>(type: "TEXT", nullable: false),
                    Masv = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.HoTen);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Test");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PTD_Ktra.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Ca2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Test",
                table: "Test");

            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "Test",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Test",
                table: "Test",
                column: "TestId");

            migrationBuilder.CreateTable(
                name: "Ca2",
                columns: table => new
                {
                    MyProperty = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ca2", x => x.MyProperty);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ca2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Test",
                table: "Test");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Test");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Test",
                table: "Test",
                column: "HoTen");
        }
    }
}

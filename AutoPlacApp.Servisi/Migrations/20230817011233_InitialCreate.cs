using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPlacApp.Servisi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Automobili",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    GodinaProizvodnje = table.Column<int>(type: "int", nullable: false),
                    Karoserija = table.Column<int>(type: "int", nullable: false),
                    Gorivo = table.Column<int>(type: "int", nullable: false),
                    Stanje = table.Column<int>(type: "int", nullable: false),
                    Cena = table.Column<int>(type: "int", nullable: false),
                    SlikaDir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kilometraža = table.Column<int>(type: "int", nullable: false),
                    Kubikaža = table.Column<int>(type: "int", nullable: false),
                    SnagaMotora = table.Column<int>(type: "int", nullable: false),
                    Boja = table.Column<int>(type: "int", nullable: false),
                    StranaVolana = table.Column<int>(type: "int", nullable: false),
                    BrojVrata = table.Column<int>(type: "int", nullable: false),
                    BrojSedista = table.Column<int>(type: "int", nullable: false),
                    Klima = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Automobili", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Automobili");
        }
    }
}

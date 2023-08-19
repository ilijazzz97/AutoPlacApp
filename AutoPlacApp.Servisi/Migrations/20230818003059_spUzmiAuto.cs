using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoPlacApp.Servisi.Migrations
{
    /// <inheritdoc />
    public partial class spUzmiAuto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedura = @"Create procedure spUzmiAuto
                                @Id int
                                as
                                Begin
                                    Select * from Automobili
                                    Where Id = @Id
                                End";
            migrationBuilder.Sql(procedura);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedura = @"Drop procedure spUzmiAuto";
            migrationBuilder.Sql(procedura);
        }
    }
}

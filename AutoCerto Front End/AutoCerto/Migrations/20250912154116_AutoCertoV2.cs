using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoCerto.Migrations
{
    /// <inheritdoc />
    public partial class AutoCertoV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Usuarios",
                newName: "SenhaHash");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "Usuarios",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "SenhaHash",
                table: "Usuarios",
                newName: "PasswordHash");
        }
    }
}

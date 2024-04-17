using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_Do_List_LABIV.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Users",
                newName: "password");
        }
    }
}

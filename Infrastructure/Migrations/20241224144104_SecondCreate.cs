using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pictureurl",
                table: "Products",
                newName: "PictureUrl");

            migrationBuilder.RenameColumn(
                name: "descrioption",
                table: "Products",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureUrl",
                table: "Products",
                newName: "Pictureurl");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "descrioption");
        }
    }
}

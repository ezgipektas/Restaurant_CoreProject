using Microsoft.EntityFrameworkCore.Migrations;

namespace Restory_Restaurant_DataAccessLayer.Migrations
{
    public partial class mig_gallery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Galleries",
                newName: "ImageUrl3");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl1",
                table: "Galleries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl2",
                table: "Galleries",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl1",
                table: "Galleries");

            migrationBuilder.DropColumn(
                name: "ImageUrl2",
                table: "Galleries");

            migrationBuilder.RenameColumn(
                name: "ImageUrl3",
                table: "Galleries",
                newName: "ImageUrl");
        }
    }
}

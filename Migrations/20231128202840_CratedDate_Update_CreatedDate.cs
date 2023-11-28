using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRUD_Operations.Migrations
{
    /// <inheritdoc />
    public partial class CratedDate_Update_CreatedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CratedDate",
                table: "Categories",
                newName: "CreatedDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Categories",
                newName: "CratedDate");
        }
    }
}

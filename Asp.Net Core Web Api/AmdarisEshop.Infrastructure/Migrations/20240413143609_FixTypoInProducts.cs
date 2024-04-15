using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AmdarisEshop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixTypoInProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdcutDescription",
                table: "Products",
                newName: "ProductDescription");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductDescription",
                table: "Products",
                newName: "ProdcutDescription");
        }
    }
}

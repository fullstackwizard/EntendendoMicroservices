using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PedidoCrud.Migrations
{
    /// <inheritdoc />
    public partial class NewService : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipoProduto",
                table: "Produtos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoProduto",
                table: "Produtos");
        }
    }
}

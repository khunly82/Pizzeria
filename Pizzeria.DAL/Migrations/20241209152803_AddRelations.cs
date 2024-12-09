using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizzeria.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IngredientPizza",
                columns: table => new
                {
                    IngredientsId = table.Column<int>(type: "int", nullable: false),
                    PizzasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientPizza", x => new { x.IngredientsId, x.PizzasId });
                    table.ForeignKey(
                        name: "FK_IngredientPizza_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IngredientPizza_Pizzas_PizzasId",
                        column: x => x.PizzasId,
                        principalTable: "Pizzas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commandes_ClientId",
                table: "Commandes",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandeLines_CommandeId",
                table: "CommandeLines",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandeLines_PizzaId",
                table: "CommandeLines",
                column: "PizzaId");

            migrationBuilder.CreateIndex(
                name: "IX_Adresse_ClientId",
                table: "Adresse",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientPizza_PizzasId",
                table: "IngredientPizza",
                column: "PizzasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresse_Clients_ClientId",
                table: "Adresse",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommandeLines_Commandes_CommandeId",
                table: "CommandeLines",
                column: "CommandeId",
                principalTable: "Commandes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommandeLines_Pizzas_PizzaId",
                table: "CommandeLines",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Commandes_Clients_ClientId",
                table: "Commandes",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresse_Clients_ClientId",
                table: "Adresse");

            migrationBuilder.DropForeignKey(
                name: "FK_CommandeLines_Commandes_CommandeId",
                table: "CommandeLines");

            migrationBuilder.DropForeignKey(
                name: "FK_CommandeLines_Pizzas_PizzaId",
                table: "CommandeLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Commandes_Clients_ClientId",
                table: "Commandes");

            migrationBuilder.DropTable(
                name: "IngredientPizza");

            migrationBuilder.DropIndex(
                name: "IX_Commandes_ClientId",
                table: "Commandes");

            migrationBuilder.DropIndex(
                name: "IX_CommandeLines_CommandeId",
                table: "CommandeLines");

            migrationBuilder.DropIndex(
                name: "IX_CommandeLines_PizzaId",
                table: "CommandeLines");

            migrationBuilder.DropIndex(
                name: "IX_Adresse_ClientId",
                table: "Adresse");
        }
    }
}

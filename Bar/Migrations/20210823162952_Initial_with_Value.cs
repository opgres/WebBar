using Microsoft.EntityFrameworkCore.Migrations;

namespace Bar.Migrations
{
    public partial class Initial_with_Value : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocktailIngredient");

            migrationBuilder.CreateTable(
                name: "Ingredient_Values",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient_Values", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredient_Values_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CocktailIngredient_Value",
                columns: table => new
                {
                    CocktailsId = table.Column<int>(type: "int", nullable: false),
                    Ingredient_ValuesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CocktailIngredient_Value", x => new { x.CocktailsId, x.Ingredient_ValuesId });
                    table.ForeignKey(
                        name: "FK_CocktailIngredient_Value_Cocktails_CocktailsId",
                        column: x => x.CocktailsId,
                        principalTable: "Cocktails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CocktailIngredient_Value_Ingredient_Values_Ingredient_ValuesId",
                        column: x => x.Ingredient_ValuesId,
                        principalTable: "Ingredient_Values",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CocktailIngredient_Value_Ingredient_ValuesId",
                table: "CocktailIngredient_Value",
                column: "Ingredient_ValuesId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_Values_IngredientId",
                table: "Ingredient_Values",
                column: "IngredientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CocktailIngredient_Value");

            migrationBuilder.DropTable(
                name: "Ingredient_Values");

            migrationBuilder.CreateTable(
                name: "CocktailIngredient",
                columns: table => new
                {
                    CocktailsId = table.Column<int>(type: "int", nullable: false),
                    IngredientsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CocktailIngredient", x => new { x.CocktailsId, x.IngredientsId });
                    table.ForeignKey(
                        name: "FK_CocktailIngredient_Cocktails_CocktailsId",
                        column: x => x.CocktailsId,
                        principalTable: "Cocktails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CocktailIngredient_Ingredients_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CocktailIngredient_IngredientsId",
                table: "CocktailIngredient",
                column: "IngredientsId");
        }
    }
}

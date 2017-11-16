using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LunchService.Migrations
{
    public partial class AddedDishToMealRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DishToMeal",
                columns: table => new
                {
                    DishId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MealId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishToMeal", x => new { x.DishId, x.MealId });
                    table.ForeignKey(
                        name: "FK_DishToMeal_Dish_DishId",
                        column: x => x.DishId,
                        principalTable: "Dish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishToMeal_Meals_MealId",
                        column: x => x.MealId,
                        principalTable: "Meals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishToMeal_MealId",
                table: "DishToMeal",
                column: "MealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishToMeal");

            migrationBuilder.DropTable(
                name: "Dish");
        }
    }
}

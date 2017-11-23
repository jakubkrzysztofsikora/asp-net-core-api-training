using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LunchService.Migrations
{
    public partial class ChangedPrimaryKeyInDishToMeal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishToMeal_Dish_DishId",
                table: "DishToMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DishToMeal",
                table: "DishToMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dish",
                table: "Dish");

            migrationBuilder.RenameTable(
                name: "Dish",
                newName: "Dishes");

            migrationBuilder.AddColumn<Guid>(
                name: "DishToMealId",
                table: "DishToMeal",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_DishToMeal",
                table: "DishToMeal",
                column: "DishToMealId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DishToMeal_DishId",
                table: "DishToMeal",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_DishToMeal_Dishes_DishId",
                table: "DishToMeal",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DishToMeal_Dishes_DishId",
                table: "DishToMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DishToMeal",
                table: "DishToMeal");

            migrationBuilder.DropIndex(
                name: "IX_DishToMeal_DishId",
                table: "DishToMeal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishes",
                table: "Dishes");

            migrationBuilder.DropColumn(
                name: "DishToMealId",
                table: "DishToMeal");

            migrationBuilder.RenameTable(
                name: "Dishes",
                newName: "Dish");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DishToMeal",
                table: "DishToMeal",
                columns: new[] { "DishId", "MealId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dish",
                table: "Dish",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DishToMeal_Dish_DishId",
                table: "DishToMeal",
                column: "DishId",
                principalTable: "Dish",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

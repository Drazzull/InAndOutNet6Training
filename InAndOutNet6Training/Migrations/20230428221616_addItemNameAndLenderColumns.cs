﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InAndOutNet6Training.Migrations
{
    public partial class addItemNameAndLenderColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Items",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lender",
                table: "Items",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "Lender",
                table: "Items");
        }
    }
}

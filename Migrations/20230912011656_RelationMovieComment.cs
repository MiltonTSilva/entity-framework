﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entity_framework.Migrations
{
    /// <inheritdoc />
    public partial class RelationMovieComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Comments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MovieId",
                table: "Comments",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Movies_MovieId",
                table: "Comments",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Movies_MovieId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_MovieId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Comments");
        }
    }
}

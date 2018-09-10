using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShauliWeb.Migrations
{
    public partial class CommentChange1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentTitle",
                table: "Comment");

            migrationBuilder.RenameColumn(
                name: "WriterName",
                table: "Comment",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Comment",
                newName: "WriterName");

            migrationBuilder.AddColumn<string>(
                name: "CommentTitle",
                table: "Comment",
                nullable: true);
        }
    }
}

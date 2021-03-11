using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace XRM.Migrations
{
    public partial class FullAuditOnAccounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DeleterId",
                table: "XrmAccounts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionTime",
                table: "XrmAccounts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "XrmAccounts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterId",
                table: "XrmAccounts");

            migrationBuilder.DropColumn(
                name: "DeletionTime",
                table: "XrmAccounts");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "XrmAccounts");
        }
    }
}

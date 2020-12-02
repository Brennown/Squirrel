using Microsoft.EntityFrameworkCore.Migrations;

namespace SquirrelData.Migrations
{
    public partial class SecoundMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "RememberMe",
                table: "Accounts",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "RememberMe",
                table: "Accounts",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT");
        }
    }
}

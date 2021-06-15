using Microsoft.EntityFrameworkCore.Migrations;

namespace PRENATALv2.Migrations
{
    public partial class InitialSet2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Doctor",
                table: "Referrals");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Doctor",
                table: "Referrals",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

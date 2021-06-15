using Microsoft.EntityFrameworkCore.Migrations;

namespace PRENATALv2.Migrations
{
    public partial class _12345 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Low",
                table: "BloodExaminations",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<double>(
                name: "High",
                table: "BloodExaminations",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Low",
                table: "BloodExaminations",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "High",
                table: "BloodExaminations",
                type: "real",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}

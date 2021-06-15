using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PRENATALv2.Migrations
{
    public partial class Photos111 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Ultrasound_UltrasoundId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Ultrasound_UltrasoundId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_UltrasoundId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Files_UltrasoundId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "UltrasoundId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "UltrasoundId",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "MedicalRecordId",
                table: "Photos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "Files",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicalRecordId",
                table: "Files",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Files",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_MedicalRecordId",
                table: "Photos",
                column: "MedicalRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_MedicalRecordId",
                table: "Files",
                column: "MedicalRecordId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_MedicalRecord_MedicalRecordId",
                table: "Files",
                column: "MedicalRecordId",
                principalTable: "MedicalRecord",
                principalColumn: "MedicalRecordId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_MedicalRecord_MedicalRecordId",
                table: "Photos",
                column: "MedicalRecordId",
                principalTable: "MedicalRecord",
                principalColumn: "MedicalRecordId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_MedicalRecord_MedicalRecordId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_MedicalRecord_MedicalRecordId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_MedicalRecordId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Files_MedicalRecordId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "MedicalRecordId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "MedicalRecordId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "UltrasoundId",
                table: "Photos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte[]>(
                name: "Content",
                table: "Files",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Files",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UltrasoundId",
                table: "Files",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UltrasoundId",
                table: "Photos",
                column: "UltrasoundId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_UltrasoundId",
                table: "Files",
                column: "UltrasoundId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Ultrasound_UltrasoundId",
                table: "Files",
                column: "UltrasoundId",
                principalTable: "Ultrasound",
                principalColumn: "UltrasoundId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Ultrasound_UltrasoundId",
                table: "Photos",
                column: "UltrasoundId",
                principalTable: "Ultrasound",
                principalColumn: "UltrasoundId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

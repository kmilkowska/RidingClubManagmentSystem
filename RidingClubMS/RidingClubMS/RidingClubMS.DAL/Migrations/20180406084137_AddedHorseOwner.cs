using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RidingClubMS.DAL.Migrations
{
    public partial class AddedHorseOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRide_Rides_RideId",
                table: "UserRide");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRide_AspNetUsers_UserId",
                table: "UserRide");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRide",
                table: "UserRide");

            migrationBuilder.RenameTable(
                name: "UserRide",
                newName: "UserRides");

            migrationBuilder.RenameIndex(
                name: "IX_UserRide_UserId",
                table: "UserRides",
                newName: "IX_UserRides_UserId");

            migrationBuilder.AddColumn<string>(
                name: "HorseOwner",
                table: "Horses",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRides",
                table: "UserRides",
                columns: new[] { "RideId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserRides_Rides_RideId",
                table: "UserRides",
                column: "RideId",
                principalTable: "Rides",
                principalColumn: "RideId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRides_AspNetUsers_UserId",
                table: "UserRides",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRides_Rides_RideId",
                table: "UserRides");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRides_AspNetUsers_UserId",
                table: "UserRides");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRides",
                table: "UserRides");

            migrationBuilder.DropColumn(
                name: "HorseOwner",
                table: "Horses");

            migrationBuilder.RenameTable(
                name: "UserRides",
                newName: "UserRide");

            migrationBuilder.RenameIndex(
                name: "IX_UserRides_UserId",
                table: "UserRide",
                newName: "IX_UserRide_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRide",
                table: "UserRide",
                columns: new[] { "RideId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserRide_Rides_RideId",
                table: "UserRide",
                column: "RideId",
                principalTable: "Rides",
                principalColumn: "RideId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRide_AspNetUsers_UserId",
                table: "UserRide",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

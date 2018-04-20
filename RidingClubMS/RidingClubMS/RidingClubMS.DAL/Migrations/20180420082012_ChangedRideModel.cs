using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RidingClubMS.DAL.Migrations
{
    public partial class ChangedRideModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrainerId",
                table: "Rides");

            migrationBuilder.AddColumn<string>(
                name: "Trainer",
                table: "Rides",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Trainer",
                table: "Rides");

            migrationBuilder.AddColumn<int>(
                name: "TrainerId",
                table: "Rides",
                nullable: false,
                defaultValue: 0);
        }
    }
}

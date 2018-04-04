using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RidingClubMS.DAL.Migrations
{
    public partial class HorsesRidesTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Horses",
                columns: table => new
                {
                    HorseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    HorseBreed = table.Column<string>(nullable: false),
                    HorseBreeder = table.Column<string>(nullable: false),
                    HorseCoulour = table.Column<string>(nullable: false),
                    HorseDam = table.Column<string>(nullable: false),
                    HorseDescription = table.Column<string>(nullable: false),
                    HorseName = table.Column<string>(nullable: false),
                    HorseSex = table.Column<string>(nullable: false),
                    HorseSire = table.Column<string>(nullable: false),
                    ImgUrl = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horses", x => x.HorseId);
                });

            migrationBuilder.CreateTable(
                name: "Rides",
                columns: table => new
                {
                    RideId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdvanceLevel = table.Column<string>(nullable: false),
                    AvailablePlaces = table.Column<int>(nullable: false),
                    RideDate = table.Column<DateTime>(nullable: false),
                    RideTime = table.Column<string>(nullable: false),
                    TrainerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rides", x => x.RideId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horses");

            migrationBuilder.DropTable(
                name: "Rides");
        }
    }
}

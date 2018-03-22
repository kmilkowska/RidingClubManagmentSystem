using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RidingClubMS.DAL.Migrations
{
    public partial class AddHorsesTable : Migration
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
                    HorseSire = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horses", x => x.HorseId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Horses");
        }
    }
}

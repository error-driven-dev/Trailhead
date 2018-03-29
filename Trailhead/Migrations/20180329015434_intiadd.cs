using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Trailhead.Migrations
{
    public partial class intiadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LatLong",
                table: "NationalParks",
                newName: "State");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "NationalParks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lat",
                table: "NationalParks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lon",
                table: "NationalParks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "NationalParks");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "NationalParks");

            migrationBuilder.DropColumn(
                name: "Lon",
                table: "NationalParks");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "NationalParks",
                newName: "LatLong");
        }
    }
}

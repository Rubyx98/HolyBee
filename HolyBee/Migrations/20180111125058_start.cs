using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HolyBee.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    GebruikerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Gebruikersnaam = table.Column<string>(nullable: true),
                    TelefoonNummer = table.Column<int>(nullable: false),
                    Wachtwoord = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.GebruikerID);
                });

            migrationBuilder.CreateTable(
                name: "MediaItem",
                columns: table => new
                {
                    MediaItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaItem", x => x.MediaItemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gebruiker");

            migrationBuilder.DropTable(
                name: "MediaItem");
        }
    }
}

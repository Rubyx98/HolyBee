﻿// <auto-generated />
using HolyBee.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HolyBee.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180111125058_start")]
    partial class start
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HolyBee.Models.Gebruiker", b =>
                {
                    b.Property<int>("GebruikerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Gebruikersnaam");

                    b.Property<int>("TelefoonNummer");

                    b.Property<string>("Wachtwoord");

                    b.HasKey("GebruikerID");

                    b.ToTable("Gebruiker");
                });

            modelBuilder.Entity("HolyBee.Models.MediaItem", b =>
                {
                    b.Property<int>("MediaItemID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("MediaItemID");

                    b.ToTable("MediaItem");
                });
#pragma warning restore 612, 618
        }
    }
}
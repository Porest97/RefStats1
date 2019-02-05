﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RefStats.Models;

namespace RefStats.Migrations
{
    [DbContext(typeof(RefStatsContext))]
    [Migration("20190202205304_Game")]
    partial class Game
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RefStats.Models.Domarlista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate");

                    b.Property<string>("Category");

                    b.Property<string>("CategoryType");

                    b.Property<string>("Club");

                    b.Property<string>("County");

                    b.Property<string>("Created");

                    b.Property<string>("Distrikt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Payed");

                    b.Property<string>("Phone1");

                    b.Property<string>("Phone2");

                    b.Property<string>("RefNumber");

                    b.Property<string>("RefType");

                    b.Property<string>("Registred");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.ToTable("Domarlista");
                });

            modelBuilder.Entity("RefStats.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Arena");

                    b.Property<int>("Fee1");

                    b.Property<int>("Fee2");

                    b.Property<DateTime>("GameDate");

                    b.Property<int>("GameDay");

                    b.Property<int>("GameTime");

                    b.Property<string>("Ref1");

                    b.Property<string>("Ref2");

                    b.Property<int>("Score1");

                    b.Property<int>("Score2");

                    b.Property<int>("Series");

                    b.Property<string>("Team1");

                    b.Property<string>("Team2");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("RefStats.Models.VeiwModels.DomarlistaViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate");

                    b.Property<string>("Category");

                    b.Property<string>("CategoryType");

                    b.Property<string>("Club");

                    b.Property<string>("County");

                    b.Property<string>("Created");

                    b.Property<string>("Distrikt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Payed");

                    b.Property<string>("Phone1");

                    b.Property<string>("Phone2");

                    b.Property<string>("RefNumber");

                    b.Property<string>("RefType");

                    b.Property<string>("Registred");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.ToTable("DomarlistaViewModel");
                });

            modelBuilder.Entity("RefStats.VeiwModels.RefDetailsViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate");

                    b.Property<string>("Category");

                    b.Property<string>("County");

                    b.Property<string>("Distrikt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Phone1");

                    b.Property<string>("Phone2");

                    b.Property<string>("RefNumber");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("Zipcode");

                    b.HasKey("Id");

                    b.ToTable("RefDetailsViewModel");
                });
#pragma warning restore 612, 618
        }
    }
}

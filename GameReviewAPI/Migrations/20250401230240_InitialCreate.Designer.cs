﻿// <auto-generated />
using System;
using GameReviewAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameReviewAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250401230240_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameReviewAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("HeadquartersId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HeadquartersId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameReviewAPI.Models.GameCategory", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("GameCategories");
                });

            modelBuilder.Entity("GameReviewAPI.Models.GameCompany", b =>
                {
                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.HasKey("GameId", "CompanyId");

                    b.HasIndex("CompanyId");

                    b.ToTable("gameCompanies");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Headquarters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Headquarters");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("ReviewerId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Reviewer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reviewers");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Company", b =>
                {
                    b.HasOne("GameReviewAPI.Models.Headquarters", "Headquarters")
                        .WithMany("Companies")
                        .HasForeignKey("HeadquartersId");

                    b.Navigation("Headquarters");
                });

            modelBuilder.Entity("GameReviewAPI.Models.GameCategory", b =>
                {
                    b.HasOne("GameReviewAPI.Models.Category", "Category")
                        .WithMany("GameCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameReviewAPI.Models.Game", "Game")
                        .WithMany("GameCategories")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GameReviewAPI.Models.GameCompany", b =>
                {
                    b.HasOne("GameReviewAPI.Models.Company", "Company")
                        .WithMany("GameCompanies")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameReviewAPI.Models.Game", "Game")
                        .WithMany("GameCompanies")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Review", b =>
                {
                    b.HasOne("GameReviewAPI.Models.Game", "Game")
                        .WithMany("Reviews")
                        .HasForeignKey("GameId");

                    b.HasOne("GameReviewAPI.Models.Reviewer", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerId");

                    b.Navigation("Game");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Category", b =>
                {
                    b.Navigation("GameCategories");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Company", b =>
                {
                    b.Navigation("GameCompanies");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Game", b =>
                {
                    b.Navigation("GameCategories");

                    b.Navigation("GameCompanies");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Headquarters", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("GameReviewAPI.Models.Reviewer", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}

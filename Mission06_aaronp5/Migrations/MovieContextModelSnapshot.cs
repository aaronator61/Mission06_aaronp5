﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_aaronp5.Models;

namespace Mission06_aaronp5.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_aaronp5.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Comedy"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Drama"
                        },
                        new
                        {
                            CategoryID = 5,
                            CategoryName = "Chick Flick"
                        });
                });

            modelBuilder.Entity("Mission06_aaronp5.Models.Movie", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("categoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("note")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("movieId");

                    b.HasIndex("categoryId");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            categoryId = 1,
                            director = "Steven Spielberg",
                            edited = true,
                            lentTo = "Jack",
                            note = "Nothing much",
                            rating = "PG-13",
                            title = "Indiana Jones"
                        },
                        new
                        {
                            movieId = 2,
                            categoryId = 1,
                            director = "Chris Columbus",
                            edited = true,
                            lentTo = "John",
                            note = "Boring",
                            rating = "PG",
                            title = "Home Alone"
                        },
                        new
                        {
                            movieId = 3,
                            categoryId = 3,
                            director = "Steven Spielberg",
                            edited = true,
                            lentTo = "James",
                            note = "Sharks",
                            rating = "PG-13",
                            title = "Jaws"
                        });
                });

            modelBuilder.Entity("Mission06_aaronp5.Models.Movie", b =>
                {
                    b.HasOne("Mission06_aaronp5.Models.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

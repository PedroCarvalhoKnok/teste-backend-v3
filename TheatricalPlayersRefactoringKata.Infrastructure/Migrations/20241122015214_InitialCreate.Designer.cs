﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheatricalPlayersRefactoringKata.Infrastructure.Data;

#nullable disable

namespace TheatricalPlayersRefactoringKata.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241122015214_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.36");

            modelBuilder.Entity("TheatricalPlayersRefactoringKata.Domain.Entities.Performance", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Audience")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Cost")
                        .HasColumnType("TEXT");

                    b.Property<int>("Credits")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("StatementId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlayId");

                    b.HasIndex("StatementId");

                    b.ToTable("Performances");
                });

            modelBuilder.Entity("TheatricalPlayersRefactoringKata.Domain.Entities.Play", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lines")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Plays");
                });

            modelBuilder.Entity("TheatricalPlayersRefactoringKata.Domain.Entities.Statement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Customer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalCredits")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Statements");
                });

            modelBuilder.Entity("TheatricalPlayersRefactoringKata.Domain.Entities.Performance", b =>
                {
                    b.HasOne("TheatricalPlayersRefactoringKata.Domain.Entities.Play", "Play")
                        .WithMany()
                        .HasForeignKey("PlayId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TheatricalPlayersRefactoringKata.Domain.Entities.Statement", "Statement")
                        .WithMany("Performances")
                        .HasForeignKey("StatementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Play");

                    b.Navigation("Statement");
                });

            modelBuilder.Entity("TheatricalPlayersRefactoringKata.Domain.Entities.Statement", b =>
                {
                    b.Navigation("Performances");
                });
#pragma warning restore 612, 618
        }
    }
}

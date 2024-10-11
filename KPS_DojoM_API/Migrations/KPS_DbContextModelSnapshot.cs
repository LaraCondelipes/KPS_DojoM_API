﻿// <auto-generated />
using System;
using KPS_DojoM_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KPS_DojoM_API.Migrations
{
    [DbContext(typeof(KPS_DbContext))]
    partial class KPS_DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoriesEvents", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.HasKey("CategoryId", "EventId");

                    b.HasIndex("EventId");

                    b.ToTable("CategoriesEvents");
                });

            modelBuilder.Entity("KPS_DojoM_models.Association", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("AssociationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Association");
                });

            modelBuilder.Entity("KPS_DojoM_models.Athletes", b =>
                {
                    b.Property<int?>("AssociationId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int?>("AssociationMemberNumber")
                        .HasColumnType("int");

                    b.Property<string>("AthleteAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AthleteBirthdayDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AthleteCcNumber")
                        .HasColumnType("int");

                    b.Property<int?>("AthleteCellPhone")
                        .HasColumnType("int");

                    b.Property<int?>("AthleteClubMemberNumber")
                        .HasColumnType("int");

                    b.Property<string>("AthleteEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AthleteKYU")
                        .HasColumnType("int");

                    b.Property<string>("AthleteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AthleteNif")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<string>("Club")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("ParentsId")
                        .HasColumnType("int");

                    b.HasKey("AssociationId", "CategoryId", "ParentId");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("ParentsId");

                    b.ToTable("Athletes");
                });

            modelBuilder.Entity("KPS_DojoM_models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TheResultsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TheResultsId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("KPS_DojoM_models.Championships", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("AssociationId")
                        .HasColumnType("int");

                    b.Property<int?>("ChampionshipName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssociationId");

                    b.ToTable("Championships");
                });

            modelBuilder.Entity("KPS_DojoM_models.Events", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TheResultsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TheResultsId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("KPS_DojoM_models.Parents", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("ParentAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCcNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ParentCellPhone")
                        .HasColumnType("int");

                    b.Property<string>("ParentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentNif")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("KPS_DojoM_models.Senseis", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("AssociationId")
                        .HasColumnType("int");

                    b.Property<int>("AssociationMemberNumber")
                        .HasColumnType("int");

                    b.Property<int?>("LicenceNumber")
                        .HasColumnType("int");

                    b.Property<string>("SeinseiName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SenseiCellPhone")
                        .HasColumnType("int");

                    b.Property<string>("SenseiEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SenseiKYU")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssociationId");

                    b.ToTable("Senseis");
                });

            modelBuilder.Entity("KPS_DojoM_models.TheResults", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<int?>("AthletesAssociationId")
                        .HasColumnType("int");

                    b.Property<int?>("AthletesCategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("AthletesParentId")
                        .HasColumnType("int");

                    b.Property<int?>("ChampionshipsId")
                        .HasColumnType("int");

                    b.Property<int?>("PodiumPlace")
                        .HasColumnType("int");

                    b.Property<string>("ResultName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChampionshipsId");

                    b.HasIndex("AthletesAssociationId", "AthletesCategoryId", "AthletesParentId");

                    b.ToTable("TheResults");
                });

            modelBuilder.Entity("CategoriesEvents", b =>
                {
                    b.HasOne("KPS_DojoM_models.Categories", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KPS_DojoM_models.Events", null)
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KPS_DojoM_models.Athletes", b =>
                {
                    b.HasOne("KPS_DojoM_models.Association", "Association")
                        .WithMany("Athlete")
                        .HasForeignKey("AssociationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KPS_DojoM_models.Categories", "Categories")
                        .WithMany("Athlete")
                        .HasForeignKey("CategoriesId");

                    b.HasOne("KPS_DojoM_models.Parents", "Parents")
                        .WithMany("athlete")
                        .HasForeignKey("ParentsId");

                    b.Navigation("Association");

                    b.Navigation("Categories");

                    b.Navigation("Parents");
                });

            modelBuilder.Entity("KPS_DojoM_models.Categories", b =>
                {
                    b.HasOne("KPS_DojoM_models.TheResults", null)
                        .WithMany("Category")
                        .HasForeignKey("TheResultsId");
                });

            modelBuilder.Entity("KPS_DojoM_models.Championships", b =>
                {
                    b.HasOne("KPS_DojoM_models.Association", null)
                        .WithMany("Championships")
                        .HasForeignKey("AssociationId");
                });

            modelBuilder.Entity("KPS_DojoM_models.Events", b =>
                {
                    b.HasOne("KPS_DojoM_models.TheResults", null)
                        .WithMany("Event")
                        .HasForeignKey("TheResultsId");
                });

            modelBuilder.Entity("KPS_DojoM_models.Senseis", b =>
                {
                    b.HasOne("KPS_DojoM_models.Association", "Association")
                        .WithMany()
                        .HasForeignKey("AssociationId");

                    b.Navigation("Association");
                });

            modelBuilder.Entity("KPS_DojoM_models.TheResults", b =>
                {
                    b.HasOne("KPS_DojoM_models.Championships", null)
                        .WithMany("Result")
                        .HasForeignKey("ChampionshipsId");

                    b.HasOne("KPS_DojoM_models.Athletes", null)
                        .WithMany("Results")
                        .HasForeignKey("AthletesAssociationId", "AthletesCategoryId", "AthletesParentId");
                });

            modelBuilder.Entity("KPS_DojoM_models.Association", b =>
                {
                    b.Navigation("Athlete");

                    b.Navigation("Championships");
                });

            modelBuilder.Entity("KPS_DojoM_models.Athletes", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("KPS_DojoM_models.Categories", b =>
                {
                    b.Navigation("Athlete");
                });

            modelBuilder.Entity("KPS_DojoM_models.Championships", b =>
                {
                    b.Navigation("Result");
                });

            modelBuilder.Entity("KPS_DojoM_models.Parents", b =>
                {
                    b.Navigation("athlete");
                });

            modelBuilder.Entity("KPS_DojoM_models.TheResults", b =>
                {
                    b.Navigation("Category");

                    b.Navigation("Event");
                });
#pragma warning restore 612, 618
        }
    }
}

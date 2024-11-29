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
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoriesEvents", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("EventsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "EventsId");

                    b.HasIndex("EventsId");

                    b.ToTable("CategoriesEvents");
                });

            modelBuilder.Entity("KPS_DojoM_models.Association", b =>
                {
                    b.Property<int>("AssociationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssociationId"));

                    b.Property<string>("AssociationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssociationId");

                    b.ToTable("Association");
                });

            modelBuilder.Entity("KPS_DojoM_models.Athletes", b =>
                {
                    b.Property<int>("AthletesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AthletesId"));

                    b.Property<int?>("AssociationId")
                        .HasColumnType("int");

                    b.Property<int?>("AssociationMemberNumber")
                        .HasColumnType("int");

                    b.Property<string>("AthleteAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AthleteBirthdayDay")
                        .HasColumnType("datetime2");

                    b.Property<int?>("AthleteCcNumber")
                        .HasColumnType("int");

                    b.Property<int?>("AthleteCellPhone")
                        .HasColumnType("int");

                    b.Property<string>("AthleteCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AthleteClubMemberNumber")
                        .HasColumnType("int");

                    b.Property<string>("AthleteCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AthleteEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AthleteGraduation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AthleteHeight")
                        .HasColumnType("int");

                    b.Property<string>("AthleteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AthleteNif")
                        .HasColumnType("int");

                    b.Property<string>("AthleteOccupacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AthletePlaceOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AthleteRegisterDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AthleteSignature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AthleteWeight")
                        .HasColumnType("int");

                    b.Property<int?>("AthleteZipCode")
                        .HasColumnType("int");

                    b.Property<string>("Club")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentAthleteSignature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentsId")
                        .HasColumnType("int");

                    b.Property<int?>("RegisterNumber")
                        .HasColumnType("int");

                    b.HasKey("AthletesId");

                    b.HasIndex("AssociationId");

                    b.HasIndex("ParentsId");

                    b.ToTable("Athletes");
                });

            modelBuilder.Entity("KPS_DojoM_models.Categories", b =>
                {
                    b.Property<int>("CategoriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriesId"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kyu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Weight")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CategoriesId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("KPS_DojoM_models.Championships", b =>
                {
                    b.Property<int>("ChampionshipsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChampionshipsId"));

                    b.Property<int?>("AssociationId")
                        .HasColumnType("int");

                    b.Property<string>("ChampionshipName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChampionshipsId");

                    b.HasIndex("AssociationId");

                    b.ToTable("Championships");
                });

            modelBuilder.Entity("KPS_DojoM_models.Events", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ChampionshipId")
                        .HasColumnType("int");

                    b.Property<int?>("ChampionshipsId")
                        .HasColumnType("int");

                    b.Property<string>("EventName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChampionshipsId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("KPS_DojoM_models.Parents", b =>
                {
                    b.Property<int>("ParentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParentsId"));

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

                    b.HasKey("ParentsId");

                    b.ToTable("Parents");
                });

            modelBuilder.Entity("KPS_DojoM_models.Senseis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AthletesId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int?>("PodiumPlace")
                        .HasColumnType("int");

                    b.Property<string>("ResultName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AthletesId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("TheResults");
                });

            modelBuilder.Entity("CategoriesEvents", b =>
                {
                    b.HasOne("KPS_DojoM_models.Categories", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KPS_DojoM_models.Events", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KPS_DojoM_models.Athletes", b =>
                {
                    b.HasOne("KPS_DojoM_models.Association", "Association")
                        .WithMany("Athletes")
                        .HasForeignKey("AssociationId");

                    b.HasOne("KPS_DojoM_models.Parents", "Parents")
                        .WithMany("Athlete")
                        .HasForeignKey("ParentsId");

                    b.Navigation("Association");

                    b.Navigation("Parents");
                });

            modelBuilder.Entity("KPS_DojoM_models.Championships", b =>
                {
                    b.HasOne("KPS_DojoM_models.Association", "Association")
                        .WithMany("Championships")
                        .HasForeignKey("AssociationId");

                    b.Navigation("Association");
                });

            modelBuilder.Entity("KPS_DojoM_models.Events", b =>
                {
                    b.HasOne("KPS_DojoM_models.Championships", "Championships")
                        .WithMany("Events")
                        .HasForeignKey("ChampionshipsId");

                    b.Navigation("Championships");
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
                    b.HasOne("KPS_DojoM_models.Athletes", "Athletes")
                        .WithMany("Results")
                        .HasForeignKey("AthletesId");

                    b.HasOne("KPS_DojoM_models.Categories", "Categories")
                        .WithMany("TheResults")
                        .HasForeignKey("CategoriesId");

                    b.Navigation("Athletes");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("KPS_DojoM_models.Association", b =>
                {
                    b.Navigation("Athletes");

                    b.Navigation("Championships");
                });

            modelBuilder.Entity("KPS_DojoM_models.Athletes", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("KPS_DojoM_models.Categories", b =>
                {
                    b.Navigation("TheResults");
                });

            modelBuilder.Entity("KPS_DojoM_models.Championships", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("KPS_DojoM_models.Parents", b =>
                {
                    b.Navigation("Athlete");
                });
#pragma warning restore 612, 618
        }
    }
}

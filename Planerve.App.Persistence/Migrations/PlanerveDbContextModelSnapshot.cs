﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Planerve.App.Persistence;

#nullable disable

namespace Planerve.App.Persistence.Migrations
{
    [DbContext(typeof(PlanerveDbContext))]
    partial class PlanerveDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.AccessToken", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsExpired")
                        .HasColumnType("bit");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastAccessedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TokenAccessLevel")
                        .HasColumnType("int");

                    b.Property<int>("TokenUses")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("AccessToken");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressLineOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLineThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLineTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalAuthority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplicationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ApplicationType")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VersionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.AuthorisedUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessLevel")
                        .HasColumnType("int");

                    b.Property<Guid>("ApplicationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ImportedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<string>("TokenUsed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId");

                    b.ToTable("AuthorisedUser");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Checklist", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("CalculatedFee")
                        .HasColumnType("bit");

                    b.Property<bool>("FormSections")
                        .HasColumnType("bit");

                    b.Property<bool>("PlansAndDocs")
                        .HasColumnType("bit");

                    b.Property<bool>("SubmittedToLocalAuthority")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Checklist");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Form", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("FormData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.FormTypeOne", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OneTextEight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextEleven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFithteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFourteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextNine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextSeven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextSix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextThirteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTwelve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextEight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextEleven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFithteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFourteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextNine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextSeven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextSix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextThirteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTwelve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTwo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormTypeOne");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.FormTypeTwo", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("OneTextEight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextEleven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFithteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextFourteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextNine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextSeven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextSix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextThirteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTwelve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OneTextTwo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextEight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextEleven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFithteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextFourteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextNine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextOne")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextSeven")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextSix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextThirteen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextThree")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTwelve")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TwoTextTwo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FormTypeTwo");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.AccessToken", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", null)
                        .WithMany("AccessTokens")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Address", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", "ApplicationData")
                        .WithOne("Address")
                        .HasForeignKey("Planerve.App.Domain.Entities.ApplicationEntities.Address", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.AuthorisedUser", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", null)
                        .WithMany("AuthorisedUsers")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Checklist", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", "ApplicationData")
                        .WithOne("ChecklistData")
                        .HasForeignKey("Planerve.App.Domain.Entities.ApplicationEntities.Checklist", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Form", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Application", "ApplicationData")
                        .WithOne("FormData")
                        .HasForeignKey("Planerve.App.Domain.Entities.ApplicationEntities.Form", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.FormTypeOne", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Form", "FormData")
                        .WithOne("FormTypeOneData")
                        .HasForeignKey("Planerve.App.Domain.Entities.FormEntities.FormTypeOne", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.FormEntities.FormTypeTwo", b =>
                {
                    b.HasOne("Planerve.App.Domain.Entities.ApplicationEntities.Form", "FormData")
                        .WithOne("FormTypeTwoData")
                        .HasForeignKey("Planerve.App.Domain.Entities.FormEntities.FormTypeTwo", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Application", b =>
                {
                    b.Navigation("AccessTokens");

                    b.Navigation("Address");

                    b.Navigation("AuthorisedUsers");

                    b.Navigation("ChecklistData");

                    b.Navigation("FormData");
                });

            modelBuilder.Entity("Planerve.App.Domain.Entities.ApplicationEntities.Form", b =>
                {
                    b.Navigation("FormTypeOneData");

                    b.Navigation("FormTypeTwoData");
                });
#pragma warning restore 612, 618
        }
    }
}

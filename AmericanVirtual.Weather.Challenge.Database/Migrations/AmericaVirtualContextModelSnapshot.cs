﻿// <auto-generated />
using System;
using AmericanVirtual.Weather.Challenge.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AmericanVirtual.Weather.Challenge.Database.Migrations
{
    [DbContext(typeof(AmericaVirtualContext))]
    partial class AmericaVirtualContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.AuthenticationToken", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("AccessToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RefreshTokenExpiryTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("AuthenticationTokens");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.PasswordPolicy", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<int>("MaximumLength")
                        .HasColumnType("int");

                    b.Property<int>("MinimumLength")
                        .HasColumnType("int");

                    b.Property<int>("MinimumNumberOfLowercaseLetters")
                        .HasColumnType("int");

                    b.Property<int>("MinimumNumberOfSpecialCharacters")
                        .HasColumnType("int");

                    b.Property<int>("MinimumNumberOfUppercaseLetters")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfDaysUntilExpire")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfFailedAttemptsAllowed")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PasswordPolicy");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long?>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FailedAttempts")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ModifiedByID")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PasswordChangeDate")
                        .HasColumnType("Date");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("ModifiedByID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.UserLogin", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.UserStateHistory", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.Property<string>("UserState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("UserID");

                    b.ToTable("UserStateHistories");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.UserTicket", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("CreatedByID")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TicketType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("CreatedByID");

                    b.HasIndex("UserID");

                    b.ToTable("UserTickets");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.AuthenticationToken", b =>
                {
                    b.HasOne("AmericanVirtual.Weather.Challenge.Database.Model.User", "User")
                        .WithMany("AuthenticationTokens")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.User", b =>
                {
                    b.HasOne("AmericanVirtual.Weather.Challenge.Database.Model.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("AmericanVirtual.Weather.Challenge.Database.Model.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedByID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedBy");

                    b.Navigation("ModifiedBy");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.UserLogin", b =>
                {
                    b.HasOne("AmericanVirtual.Weather.Challenge.Database.Model.User", "User")
                        .WithMany("Logings")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.UserStateHistory", b =>
                {
                    b.HasOne("AmericanVirtual.Weather.Challenge.Database.Model.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AmericanVirtual.Weather.Challenge.Database.Model.User", "User")
                        .WithMany("UserStatesHistory")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.UserTicket", b =>
                {
                    b.HasOne("AmericanVirtual.Weather.Challenge.Database.Model.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AmericanVirtual.Weather.Challenge.Database.Model.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AmericanVirtual.Weather.Challenge.Database.Model.User", b =>
                {
                    b.Navigation("AuthenticationTokens");

                    b.Navigation("Logings");

                    b.Navigation("Tickets");

                    b.Navigation("UserStatesHistory");
                });
#pragma warning restore 612, 618
        }
    }
}

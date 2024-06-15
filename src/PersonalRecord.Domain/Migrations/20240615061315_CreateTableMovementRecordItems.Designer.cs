﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalRecord.Domain.Models.Entities;

#nullable disable

namespace PersonalRecord.Domain.Migrations
{
    [DbContext(typeof(PersonalRecordContext))]
    [Migration("20240615061315_CreateTableMovementRecordItems")]
    partial class CreateTableMovementRecordItems
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("PersonalRecord.Domain.Models.Entities.Movement", b =>
                {
                    b.Property<Guid>("MovementID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MovementID");

                    b.ToTable("MovementItems");
                });

            modelBuilder.Entity("PersonalRecord.Domain.Models.Entities.MovementRecord", b =>
                {
                    b.Property<Guid>("MovementRecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MvrDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("MvrMovementID_FK")
                        .HasColumnType("TEXT");

                    b.Property<int>("MvrReps")
                        .HasColumnType("INTEGER");

                    b.Property<float>("MvrWeight")
                        .HasColumnType("REAL");

                    b.HasKey("MovementRecordID");

                    b.HasIndex("MvrMovementID_FK");

                    b.ToTable("MovementRecordItems");
                });

            modelBuilder.Entity("PersonalRecord.Domain.Models.Entities.MovementRecord", b =>
                {
                    b.HasOne("PersonalRecord.Domain.Models.Entities.Movement", "Movement")
                        .WithMany()
                        .HasForeignKey("MvrMovementID_FK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movement");
                });
#pragma warning restore 612, 618
        }
    }
}

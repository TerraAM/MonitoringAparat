﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonitoringAparat;

#nullable disable

namespace MonitoringAparat.Migrations
{
    [DbContext(typeof(MonitContext))]
    [Migration("20240504162901_mat")]
    partial class mat
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("MonitoringAparat.Entitties.Apparat", b =>
                {
                    b.Property<int?>("ApparatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ApparatId");

                    b.HasIndex("LineId");

                    b.ToTable("Apparature");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.CountMaterialDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DayMatId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaterialId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("count")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DayMatId");

                    b.HasIndex("MaterialId");

                    b.ToTable("CountMaterialDay");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("TEXT");

                    b.HasKey("DayId");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.DayMat", b =>
                {
                    b.Property<int>("DayMatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("day")
                        .HasColumnType("TEXT");

                    b.HasKey("DayMatId");

                    b.ToTable("DayMats");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Line", b =>
                {
                    b.Property<int>("LineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaterialId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LineId");

                    b.HasIndex("MaterialId");

                    b.ToTable("Lines");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Material", b =>
                {
                    b.Property<int>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("strength")
                        .HasColumnType("INTEGER");

                    b.Property<int>("syslo")
                        .HasColumnType("INTEGER");

                    b.Property<double>("volume")
                        .HasColumnType("REAL");

                    b.HasKey("MaterialId");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Part", b =>
                {
                    b.Property<int>("PartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ApparatId")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("Change")
                        .HasColumnType("TEXT");

                    b.Property<int>("Limit")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LineId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NamePart")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PartStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Worked")
                        .HasColumnType("INTEGER");

                    b.HasKey("PartId");

                    b.HasIndex("ApparatId");

                    b.HasIndex("LineId");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Period", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DayId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("Periods");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Apparat", b =>
                {
                    b.HasOne("MonitoringAparat.Entitties.Line", null)
                        .WithMany("Apparat")
                        .HasForeignKey("LineId");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.CountMaterialDay", b =>
                {
                    b.HasOne("MonitoringAparat.Entitties.DayMat", null)
                        .WithMany("countmaterial")
                        .HasForeignKey("DayMatId");

                    b.HasOne("MonitoringAparat.Entitties.Material", "material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("material");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Line", b =>
                {
                    b.HasOne("MonitoringAparat.Entitties.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Part", b =>
                {
                    b.HasOne("MonitoringAparat.Entitties.Apparat", null)
                        .WithMany("Parts")
                        .HasForeignKey("ApparatId");

                    b.HasOne("MonitoringAparat.Entitties.Line", null)
                        .WithMany("Parts")
                        .HasForeignKey("LineId");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Period", b =>
                {
                    b.HasOne("MonitoringAparat.Entitties.Day", null)
                        .WithMany("Periods")
                        .HasForeignKey("DayId");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Apparat", b =>
                {
                    b.Navigation("Parts");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Day", b =>
                {
                    b.Navigation("Periods");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.DayMat", b =>
                {
                    b.Navigation("countmaterial");
                });

            modelBuilder.Entity("MonitoringAparat.Entitties.Line", b =>
                {
                    b.Navigation("Apparat");

                    b.Navigation("Parts");
                });
#pragma warning restore 612, 618
        }
    }
}

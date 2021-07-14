﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SatoshisCrypto.Models;

namespace SatoshisCrypto.Migrations
{
    [DbContext(typeof(SatoshisCryptoContext))]
    [Migration("20210714014226_intial")]
    partial class intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SatoshisCrypto.Models.AdaComment", b =>
                {
                    b.Property<int>("AdaCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AdaCommentId1")
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Created_Utc")
                        .HasColumnType("int");

                    b.Property<string>("id")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AdaCommentId");

                    b.HasIndex("AdaCommentId1");

                    b.ToTable("AdaComments");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.BtcComment", b =>
                {
                    b.Property<int>("BtcCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("BtcCommentId1")
                        .HasColumnType("int");

                    b.Property<int>("Created_Utc")
                        .HasColumnType("int");

                    b.Property<string>("id")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BtcCommentId");

                    b.HasIndex("BtcCommentId1");

                    b.ToTable("BtcComments");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.DogeComment", b =>
                {
                    b.Property<int>("DogeCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Created_Utc")
                        .HasColumnType("int");

                    b.Property<int?>("DogeCommentId1")
                        .HasColumnType("int");

                    b.Property<string>("id")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DogeCommentId");

                    b.HasIndex("DogeCommentId1");

                    b.ToTable("DogeComments");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.EthComment", b =>
                {
                    b.Property<int>("EthCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Created_Utc")
                        .HasColumnType("int");

                    b.Property<int?>("EthCommentId1")
                        .HasColumnType("int");

                    b.Property<string>("id")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("EthCommentId");

                    b.HasIndex("EthCommentId1");

                    b.ToTable("EthComments");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.LinkComment", b =>
                {
                    b.Property<int>("LinkCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Created_Utc")
                        .HasColumnType("int");

                    b.Property<int?>("LinkCommentId1")
                        .HasColumnType("int");

                    b.Property<string>("id")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("LinkCommentId");

                    b.HasIndex("LinkCommentId1");

                    b.ToTable("LinkComments");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.AdaComment", b =>
                {
                    b.HasOne("SatoshisCrypto.Models.AdaComment", null)
                        .WithMany("AdaComments")
                        .HasForeignKey("AdaCommentId1");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.BtcComment", b =>
                {
                    b.HasOne("SatoshisCrypto.Models.BtcComment", null)
                        .WithMany("BtcComments")
                        .HasForeignKey("BtcCommentId1");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.DogeComment", b =>
                {
                    b.HasOne("SatoshisCrypto.Models.DogeComment", null)
                        .WithMany("DogeComments")
                        .HasForeignKey("DogeCommentId1");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.EthComment", b =>
                {
                    b.HasOne("SatoshisCrypto.Models.EthComment", null)
                        .WithMany("EthComments")
                        .HasForeignKey("EthCommentId1");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.LinkComment", b =>
                {
                    b.HasOne("SatoshisCrypto.Models.LinkComment", null)
                        .WithMany("LinkComments")
                        .HasForeignKey("LinkCommentId1");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.AdaComment", b =>
                {
                    b.Navigation("AdaComments");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.BtcComment", b =>
                {
                    b.Navigation("BtcComments");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.DogeComment", b =>
                {
                    b.Navigation("DogeComments");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.EthComment", b =>
                {
                    b.Navigation("EthComments");
                });

            modelBuilder.Entity("SatoshisCrypto.Models.LinkComment", b =>
                {
                    b.Navigation("LinkComments");
                });
#pragma warning restore 612, 618
        }
    }
}
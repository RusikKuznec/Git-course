﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web_first.EfStuff;

namespace Web_first.Migrations
{
    [DbContext(typeof(WebContext))]
    [Migration("20230603232956_Add-imageComment")]
    partial class AddimageComment
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web_first.EfStuff.DbModel.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Web_first.EfStuff.DbModel.ImageComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Web_first.EfStuff.DbModel.ImageComment", b =>
                {
                    b.HasOne("Web_first.EfStuff.DbModel.Image", "Image")
                        .WithMany("Comments")
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Web_first.EfStuff.DbModel.Image", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatingApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200708203240_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("DatingApp.API.Models.Value", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Name")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}

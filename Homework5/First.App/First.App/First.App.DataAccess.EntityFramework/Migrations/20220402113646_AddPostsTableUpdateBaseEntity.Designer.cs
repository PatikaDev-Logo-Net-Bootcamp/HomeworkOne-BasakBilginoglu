﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;


namespace First.App.DataAccess.EntityFramework.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220402113646_AddPostsTableUpdateBaseEntity")]
    partial class AddPostsTableUpdateBaseEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("First.App.Domain.Entities.Company", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Address")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("City")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Country")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("CreatedBy")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsDeleted")
                    .HasColumnType("bit");

                b.Property<DateTime?>("LastUpdatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("LastUpdatedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Location")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Phone")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("Companies");
            });

            modelBuilder.Entity("First.App.Domain.Entities.Post", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Body")
                    .HasColumnType("nvarchar(max)");

                b.Property<DateTime>("CreatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("CreatedBy")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<bool>("IsDeleted")
                    .HasColumnType("bit");

                b.Property<DateTime?>("LastUpdatedAt")
                    .HasColumnType("datetime2");

                b.Property<string>("LastUpdatedBy")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Title")
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("UserId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("Posts");
            });
#pragma warning restore 612, 618
        }
    }
}

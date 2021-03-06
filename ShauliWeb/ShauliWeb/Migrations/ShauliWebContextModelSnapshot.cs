﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ShauliWeb.Models;

namespace ShauliWeb.Migrations
{
    [DbContext(typeof(ShauliWebContext))]
    partial class ShauliWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShauliWeb.Models.Comment", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CommentText");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Website");

                    b.HasKey("CommentID");

                    b.ToTable("Comment");
                });
        }
    }
}

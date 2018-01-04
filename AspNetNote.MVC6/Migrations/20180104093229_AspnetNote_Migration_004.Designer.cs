﻿// <auto-generated />
using AspNetNote.MVC6.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AspNetNote.MVC6.Migrations
{
    [DbContext(typeof(AspnetNoteDbContext))]
    [Migration("20180104093229_AspnetNote_Migration_004")]
    partial class AspnetNote_Migration_004
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetNote.MVC6.Models.Note", b =>
                {
                    b.Property<int>("Note_Num")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Note_Contents")
                        .IsRequired();

                    b.Property<string>("Note_Title")
                        .IsRequired();

                    b.Property<int>("User_Num");

                    b.HasKey("Note_Num");

                    b.HasIndex("User_Num");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("AspNetNote.MVC6.Models.User", b =>
                {
                    b.Property<int>("User_Num")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("User_Id")
                        .IsRequired();

                    b.Property<string>("User_Name")
                        .IsRequired();

                    b.Property<string>("User_Password")
                        .IsRequired();

                    b.HasKey("User_Num");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AspNetNote.MVC6.Models.Note", b =>
                {
                    b.HasOne("AspNetNote.MVC6.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("User_Num")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using dotnettodo.Data;

namespace dotnettodo.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20170501182523_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("dotnettodo.Models.ToDoTask", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Done");

                    b.Property<string>("Title");

                    b.HasKey("ID");

                    b.ToTable("ToDoTasks");
                });
        }
    }
}

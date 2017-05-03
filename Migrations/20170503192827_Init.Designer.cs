using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using dotnettodo.Data;

namespace dotnettodo.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20170503192827_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("dotnettodo.Models.Label", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("dotnettodo.Models.ToDoTask", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Done");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int?>("labelID");

                    b.HasKey("ID");

                    b.HasIndex("labelID");

                    b.ToTable("ToDoTasks");
                });

            modelBuilder.Entity("dotnettodo.Models.ToDoTask", b =>
                {
                    b.HasOne("dotnettodo.Models.Label", "label")
                        .WithMany("ToDoTasks")
                        .HasForeignKey("labelID");
                });
        }
    }
}

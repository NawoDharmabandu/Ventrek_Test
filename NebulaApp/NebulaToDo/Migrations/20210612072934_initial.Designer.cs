// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NebulaToDo.Models;

namespace NebulaToDo.Migrations
{
    [DbContext(typeof(NebulaDbContext))]
    [Migration("20210612072934_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("NebulaToDo.Models.STATUSES", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("STATUS_ID")
                        .HasColumnType("int");

                    b.Property<string>("STATUS_NAME")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.ToTable("STATUS");
                });

            modelBuilder.Entity("NebulaToDo.Models.TASK_DETAILS", b =>
                {
                    b.Property<int>("TASK_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CREATED_BY")
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("DUE_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("MODIFIED_BY")
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("MODIFIED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("TASK_NAME")
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TASK_STATUS")
                        .HasColumnType("int");

                    b.HasKey("TASK_ID");

                    b.ToTable("TASK_DETAIL");
                });

            modelBuilder.Entity("NebulaToDo.Models.USERS", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CREATED_BY")
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("CREATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("DEACTIVATED_BY")
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("DEATIVATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("MODERATED_BY")
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("MODERATED_DATE")
                        .HasColumnType("datetime");

                    b.Property<string>("USER_CONTACT")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("USER_EMAIL")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("USER_FNAME")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("USER_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("USER_LNAME")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("USER_PASSWORD")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("USER_STATUS")
                        .HasColumnType("int");

                    b.Property<string>("USER_TITLE")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("ID");

                    b.ToTable("USER");
                });
#pragma warning restore 612, 618
        }
    }
}

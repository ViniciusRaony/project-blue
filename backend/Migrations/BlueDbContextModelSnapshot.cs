﻿// <auto-generated />
using Blue.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blue.Migrations
{
    [DbContext(typeof(BlueDbContext))]
    partial class BlueDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blue.Models.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Email");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR")
                        .HasColumnName("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Agenda", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}

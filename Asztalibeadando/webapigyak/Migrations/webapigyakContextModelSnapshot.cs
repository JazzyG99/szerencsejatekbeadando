﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapigyak.Data;

#nullable disable

namespace webapigyak.Migrations
{
    [DbContext(typeof(webapigyakContext))]
    partial class webapigyakContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassLibrary.Models.Huzas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Szam1")
                        .HasColumnType("int");

                    b.Property<int>("Szam2")
                        .HasColumnType("int");

                    b.Property<int>("Szam3")
                        .HasColumnType("int");

                    b.Property<int>("Szam4")
                        .HasColumnType("int");

                    b.Property<int>("Szam5")
                        .HasColumnType("int");

                    b.Property<int>("Szam6")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Huzas");
                });
#pragma warning restore 612, 618
        }
    }
}

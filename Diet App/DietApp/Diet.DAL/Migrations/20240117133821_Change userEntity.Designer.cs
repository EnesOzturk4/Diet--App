﻿// <auto-generated />
using System;
using Diet.DAL.Context.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Diet.DAL.Migrations
{
    [DbContext(typeof(DiyetDbContext))]
    [Migration("20240117133821_Change userEntity")]
    partial class ChangeuserEntity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.FoodCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FoodCategories");
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.MealDietRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("NutrientId")
                        .HasColumnType("int");

                    b.Property<float>("Portion")
                        .HasColumnType("real");

                    b.Property<int>("RepastId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NutrientId")
                        .IsUnique();

                    b.HasIndex("RepastId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("MealDietRecords");
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.Nutrient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Calorie")
                        .HasColumnType("float");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("FoodCategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Picture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("FoodCategoryId");

                    b.ToTable("Nutrients");
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.Repast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Repasts");
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DataStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Size")
                        .HasColumnType("real");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.MealDietRecord", b =>
                {
                    b.HasOne("Diet.DAL.Entites.Concrete.Nutrient", "Nutrient")
                        .WithOne("MealDietRecord")
                        .HasForeignKey("Diet.DAL.Entites.Concrete.MealDietRecord", "NutrientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diet.DAL.Entites.Concrete.Repast", "Repast")
                        .WithOne("MealDietRecord")
                        .HasForeignKey("Diet.DAL.Entites.Concrete.MealDietRecord", "RepastId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diet.DAL.Entites.Concrete.User", "User")
                        .WithOne("MealDietRecord")
                        .HasForeignKey("Diet.DAL.Entites.Concrete.MealDietRecord", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nutrient");

                    b.Navigation("Repast");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.Nutrient", b =>
                {
                    b.HasOne("Diet.DAL.Entites.Concrete.FoodCategory", "FoodCategory")
                        .WithMany("Nutrients")
                        .HasForeignKey("FoodCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FoodCategory");
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.Repast", b =>
                {
                    b.HasOne("Diet.DAL.Entites.Concrete.User", null)
                        .WithMany("Repasts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.FoodCategory", b =>
                {
                    b.Navigation("Nutrients");
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.Nutrient", b =>
                {
                    b.Navigation("MealDietRecord")
                        .IsRequired();
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.Repast", b =>
                {
                    b.Navigation("MealDietRecord")
                        .IsRequired();
                });

            modelBuilder.Entity("Diet.DAL.Entites.Concrete.User", b =>
                {
                    b.Navigation("MealDietRecord")
                        .IsRequired();

                    b.Navigation("Repasts");
                });
#pragma warning restore 612, 618
        }
    }
}

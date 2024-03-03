using Diet.DAL.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.DAL.Context.EF
{
    public class DiyetDbContext : DbContext
    {
        public DbSet<FoodCategory> FoodCategories { get; set; }
        public DbSet<MealDietRecord> MealDietRecords { get; set; }
        public DbSet<Nutrient> Nutrients { get; set; }
        public DbSet<Repast> Repasts { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Data Source=DESKTOP-A7N4232;Database=Dietank15;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            string connectionStringCihan = @"Server = P96ANV; Database = DietAnk15; Trusted_Connection = True;TrustServerCertificate=True";

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionStringCihan);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodCategory>()
                        .HasIndex(x => x.Name)
                        .IsUnique();

            modelBuilder.Entity<MealDietRecord>()
                        .HasIndex(x => new { x.UserId, x.NutrientId, x.RepastId })
                        .IsUnique();

            modelBuilder.Entity<FoodCategory>()
                        .HasIndex(x => x.Name)
                        .IsUnique();

            modelBuilder.Entity<Nutrient>()
                        .HasOne(x => x.FoodCategory)
                        .WithMany(x => x.Nutrients)
                        .HasForeignKey(x => x.FoodCategoryId);

            modelBuilder.Entity<MealDietRecord>()
                        .HasOne(x => x.Nutrient)
                        .WithMany(x => x.MealDietRecord)
                        .HasForeignKey(x => x.NutrientId);

            modelBuilder.Entity<MealDietRecord>()
                        .HasOne(x => x.Repast)
                        .WithMany(x => x.MealDietRecord)
                        .HasForeignKey(x => x.RepastId);

            modelBuilder.Entity<MealDietRecord>()
                        .HasOne(x => x.User)
                        .WithMany(x => x.MealDietRecords)
                        .HasForeignKey(x => x.UserId);
        }
    }

}

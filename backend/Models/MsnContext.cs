using System;
using Microsoft.EntityFrameworkCore;

namespace prid2122_g03.Models
{
    public class MsnContext : DbContext
    {
        public MsnContext(DbContextOptions<MsnContext> options)
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>().HasIndex(m => m.FullName).IsUnique();

            modelBuilder.Entity<Member>().HasData(
                new Member { Pseudo = "admin", Password = "admin", FullName = "Admin", Role = Role.Admin },
                new Member { Pseudo = "ben", Password = "ben", FullName = "Benoît Penelle", BirthDate = new DateTime(1970, 1, 2) },
                new Member { Pseudo = "bruno", Password = "bruno", FullName = "Bruno Lacroix", BirthDate = new DateTime(1971, 2, 3) },
                new Member { Pseudo = "alain", Password = "alain", FullName = "Alain Silovy" },
                new Member { Pseudo = "xavier", Password = "xavier", FullName = "Xavier Pigeolet" },
                new Member { Pseudo = "boris", Password = "boris", FullName = "Boris Verhaegen" },
                new Member { Pseudo = "marc", Password = "marc", FullName = "Marc Michel" }
            );
        }

        public void SeedData() {
            Database.BeginTransaction();

            SaveChanges();
            Database.CommitTransaction();
        }

        public DbSet<Member> Members { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Exercise6_1
{
    public class Context:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<PriceOffer> PriceOffers { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void
            OnConfiguring(
                DbContextOptionsBuilder ob)
        {
            ob.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Exercise6_1;Integrated Security=True;" +
                            "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


        //protected override void OnModelCreating(ModelBuilder mb)
        //{
        //    mb.Entity<Book>().HasKey(b => b.BookId);
        //    mb.Entity<Author>().HasKey(a => a.AuhthorId);
        //    mb.Entity<PriceOffer>().HasKey(p => p.PriceOfferId);
        //    mb.Entity<Review>().HasKey(r => r.ReviewId);
        //}

        //protected override void BuildModel(ModelBuilder modelBuilder)
        //{

        //}


    }
}

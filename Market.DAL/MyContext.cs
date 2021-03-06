﻿using Market.Models.Entities;
using System.Data.Entity;

namespace Market.DAL
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MarketCon")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Urun>()
                .Property(x => x.Kdv).
                HasPrecision(5, 3);
        }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }      
        public virtual DbSet<Satis> Satislar { get; set; }
        public virtual DbSet<Fis> Fisler { get; set; }
    }
}

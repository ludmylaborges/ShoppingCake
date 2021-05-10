using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShoppingCake.Domain.Products;
using ShoppingCake.Domain.Purchases;
using ShoppingCake.Domain.ShoppingCarts;
using ShoppingCake.Domain.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCake.Infra.Context
{
    public class DbContextShoppingCake : DbContext
    {
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ShoppingCartProduct> ShoppingCartProduct { get; set; }
        public DbSet<ShoppingCart> ShoppingCart { get; set; }
        public DbSet<PaymentType> PaymentType { get; set; }
        public DbSet<Purchase> Purchase { get; set; }
        public DbSet<User> User { get; set; }

        public DbContextShoppingCake()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LUDY\\sqlexpress;Database=shoppingcake;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ShoppingCartProduct>().HasKey(scp => new { scp.ProductId, scp.ShoppingCartId });
        }

    }
}

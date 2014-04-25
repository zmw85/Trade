namespace Trade.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TradeContext : DbContext
    {
        public TradeContext()
            : base("name=TradeContext")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<CodeTableEntry> CodeTableEntries { get; set; }
        public virtual DbSet<CodeTable> CodeTables { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductVariant> ProductVariants { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeTableEntry>()
                .HasMany(e => e.ProductAttributes)
                .WithRequired(e => e.CodeTableEntry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeTable>()
                .HasMany(e => e.CodeTableEntries)
                .WithRequired(e => e.CodeTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodeTable>()
                .HasMany(e => e.ProductAttributes)
                .WithRequired(e => e.CodeTable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryISOCode)
                .IsFixedLength();

            modelBuilder.Entity<Country>()
                .Property(e => e.CountryName)
                .IsUnicode(false);

            modelBuilder.Entity<Currency>()
                .Property(e => e.CurrencyCode)
                .IsFixedLength();

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.Countries)
                .WithRequired(e => e.Currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Price>()
                .Property(e => e.Price1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Price>()
                .HasMany(e => e.ProductPrices)
                .WithRequired(e => e.Price)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductNumber)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Prices)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductAttributes)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductPrices)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.ProductVariants)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}

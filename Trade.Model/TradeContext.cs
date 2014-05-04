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

        public virtual DbSet<AdminUser> AdminUsers { get; set; }
        public virtual DbSet<AdminUserType> AdminUserTypes { get; set; }
        public virtual DbSet<ManagementPage> ManagementPages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminUser>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<AdminUser>()
                .Property(e => e.UserId)
                .IsUnicode(false);

            modelBuilder.Entity<AdminUser>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<AdminUserType>()
                .Property(e => e.UserTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<AdminUserType>()
                .HasMany(e => e.AdminUsers)
                .WithRequired(e => e.AdminUserType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminUserType>()
                .HasMany(e => e.ManagementPages)
                .WithMany(e => e.AdminUserTypes)
                .Map(m => m.ToTable("ManagementPage_AdminUserTypes").MapLeftKey("AdminUserTypeId").MapRightKey("ManagementPageId"));

            modelBuilder.Entity<ManagementPage>()
                .Property(e => e.PageTitle)
                .IsUnicode(false);

            modelBuilder.Entity<ManagementPage>()
                .Property(e => e.Route)
                .IsUnicode(false);
        }
    }
}

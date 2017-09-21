namespace SWDomain.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SWModel : DbContext
    {
        public SWModel()
            : base("name=SWModel")
        {
        }

        public virtual DbSet<Item> TItem { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);
        }
    }
}

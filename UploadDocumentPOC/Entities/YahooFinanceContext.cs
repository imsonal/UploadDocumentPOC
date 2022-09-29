using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UploadDocumentPOCWebAPI.Entities
{
    public partial class YahooFinanceContext : DbContext
    {
        public YahooFinanceContext()
        {
        }

        public YahooFinanceContext(DbContextOptions<YahooFinanceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<StockDataLogMst> StockDataLogMsts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.;user=sa;password=123;Database=YahooFinance;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StockDataLogMst>(entity =>
            {
                entity.ToTable("StockDataLogMst");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DayOfWeek).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

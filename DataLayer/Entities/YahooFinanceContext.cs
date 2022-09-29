using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataLayer.Entities
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
        public virtual DbSet<StockHistoryMst> StockHistoryMsts { get; set; } = null!;
        public virtual DbSet<SymbolDataMst> SymbolDataMsts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
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

            modelBuilder.Entity<StockHistoryMst>(entity =>
            {
                entity.ToTable("StockHistoryMst");

                entity.Property(e => e.Openvalue).HasColumnName("openvalue");
            });

            modelBuilder.Entity<SymbolDataMst>(entity =>
            {
                entity.ToTable("SymbolDataMst");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EarningTime).HasColumnType("datetime");

                entity.Property(e => e.EarningTimeEnd).HasColumnType("datetime");

                entity.Property(e => e.EarningTimeStampStart).HasColumnName("EarningTImeStampStart");

                entity.Property(e => e.EarningTimeStart).HasColumnType("datetime");

                entity.Property(e => e.ExchangeCloseTime).HasColumnType("datetime");

                entity.Property(e => e.Openvalue).HasColumnName("openvalue");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataLayer.Entities
{
    public partial class UserLogContext : DbContext
    {
        public UserLogContext()
        {
        }

        public UserLogContext(DbContextOptions<UserLogContext> options)
            : base(options)
        {
        }

        public virtual DbSet<UserLogMst> UserLogMsts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;user=sa;password=123;Database=UserLog;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserLogMst>(entity =>
            {
                entity.ToTable("UserLogMst");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.ResponseDate).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

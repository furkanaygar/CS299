using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bilet.Model
{
    public partial class BiletContext : DbContext
    {
        public BiletContext()
        {
        }

        public BiletContext(DbContextOptions<BiletContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBilet> TblBilet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server = localhost, 1433; Database = bilet; User = sa; Password = Furkan66;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBilet>(entity =>
            {

                entity.HasKey(e => e.BiletId);

                entity.ToTable("Tbl_Bilet");

                entity.Property(e => e.BiletId).HasColumnName("BiletID");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BiletTarihi).HasColumnType("datetime");

                entity.Property(e => e.Soyisim)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Aktivite)
                   .IsRequired()
                   .HasMaxLength(150)
                   .IsUnicode(false);

                entity.Property(e => e.BiletSayisi)
                  .IsRequired()
                  .HasMaxLength(150)
                  .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

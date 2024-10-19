using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Hotel.Data
{
    public partial class HMSContext : DbContext
    {
        public HMSContext()
        {
        }

        public HMSContext(DbContextOptions<HMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBank> TblBank { get; set; }
        public virtual DbSet<TblFasilitasBisinis> TblFasilitasBisinis { get; set; }
        public virtual DbSet<TblFasilitasKamar> TblFasilitasKamar { get; set; }
        public virtual DbSet<TblFasilitasMakanan> TblFasilitasMakanan { get; set; }
        public virtual DbSet<TblFasilitasPublik> TblFasilitasPublik { get; set; }
        public virtual DbSet<TblFasilitasTransportasi> TblFasilitasTransportasi { get; set; }
        public virtual DbSet<TblFasilitasUmum> TblFasilitasUmum { get; set; }
        public virtual DbSet<TblKdPajak> TblKdPajak { get; set; }
        public virtual DbSet<TblMasterKamar> TblMasterRoom { get; set; }
        public virtual DbSet<TblPembatalan> TblPembatalan { get; set; }
        public virtual DbSet<TblReservation> TblReservation { get; set; }
        public virtual DbSet<TblService> TblService { get; set; }
        public virtual DbSet<TblTipePembayaran> TblTipePembayaran { get; set; }
        public virtual DbSet<TblCustomer> TblCustomer { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ASEPMUNANDAR122;Database=HMS;User ID=sa;Password=Laskar122;Integrated Security=false;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBank>(entity =>
            {
                entity.ToTable("tbl_Bank");

                entity.Property(e => e.Bank)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFasilitasBisinis>(entity =>
            {
                entity.ToTable("tbl_FasilitasBisinis");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Fasilitas)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFasilitasKamar>(entity =>
            {
                entity.ToTable("tbl_FasilitasKamar");

                entity.Property(e => e.Descrption)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Fasilitas)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFasilitasMakanan>(entity =>
            {
                entity.ToTable("tbl_FasilitasMakanan");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MakananMinuman)
                    .HasColumnName("Makanan_Minuman")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFasilitasPublik>(entity =>
            {
                entity.ToTable("tbl_FasilitasPublik");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Fasilitas)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFasilitasTransportasi>(entity =>
            {
                entity.ToTable("tbl_FasilitasTransportasi");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Fasilitas)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFasilitasUmum>(entity =>
            {
                entity.ToTable("tbl_FasilitasUmum");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Fasilitas)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblKdPajak>(entity =>
            {
                entity.ToTable("tbl_KdPajak");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.KdPajak)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPembatalan>(entity =>
            {
                entity.ToTable("tbl_Pembatalan");

                entity.Property(e => e.Alasan)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TglPembatalan).HasColumnType("datetime");

                entity.Property(e => e.User)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblReservation>(entity =>
            {
                entity.HasKey(e => e.KdReservation);

                entity.ToTable("tbl_Reservation");

                entity.Property(e => e.KdReservation)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Agama)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Alamat).HasColumnType("text");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.EndTo).HasColumnType("datetime");

                entity.Property(e => e.JenisKelamin)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.KewargaNegaraan)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Nik)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Pekerjaan)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.StartFrom).HasColumnType("datetime");

                entity.Property(e => e.StatusPribadi)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusReservation)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TempatLahir)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TglLahir).HasColumnType("datetime");

                entity.Property(e => e.TglReservasi).HasColumnType("datetime");

                entity.Property(e => e.TipePemabayaran)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblService>(entity =>
            {
                entity.ToTable("tbl_Service");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Services)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTipePembayaran>(entity =>
            {
                entity.ToTable("tbl_TipePembayaran");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TipePembayaran)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMasterKamar>(entity =>
            {
                entity.HasKey(e => e.KdKamar)
                    .HasName("PK_tbl_MasterRoom");

                entity.ToTable("tbl_MasterKamar");

                entity.Property(e => e.KdKamar)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.ServiceHotel).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Tamu)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TipeKamar)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TipeRanjang)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UkuranKamar)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.HasKey(e => e.Nik);

                entity.ToTable("tbl_Customer");

                entity.Property(e => e.Nik)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Agama)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Alamat).HasColumnType("text");

                entity.Property(e => e.JenisKelamin)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.KewargaNegaraan)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Nama)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Pekerjaan)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StatusPribadi)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TempatLahir)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.TglLahir).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

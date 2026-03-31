using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;




namespace Lab9_QuanLyThuVien.Models;

public partial class QLThuVienContext : DbContext
{
    public QLThuVienContext()
    {
    }

    public QLThuVienContext(DbContextOptions<QLThuVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bangcap> Bangcaps { get; set; }

    public virtual DbSet<Docgium> Docgia { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phieumuonsach> Phieumuonsaches { get; set; }

    public virtual DbSet<Phieuthutien> Phieuthutiens { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<Thamso> Thamsos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ThanhLamHet\\SQLEXPRESS;Database=QLThuVien;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bangcap>(entity =>
        {
            entity.HasKey(e => e.MaBangCap).HasName("PK__BANGCAP__5CA48D4B1A46EB8B");

            entity.ToTable("BANGCAP");

            entity.Property(e => e.TenBangCap).HasMaxLength(40);
        });

        modelBuilder.Entity<Docgium>(entity =>
        {
            entity.HasKey(e => e.MaDocGia).HasName("PK__DOCGIA__F165F9452C5E8FC2");

            entity.ToTable("DOCGIA");

            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.HoTenDocGia).HasMaxLength(60);
            entity.Property(e => e.NgayHetHan).HasColumnType("datetime");
            entity.Property(e => e.NgayLapThe).HasColumnType("datetime");
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NHANVIEN__77B2CA4792784B67");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.DiaChi).HasMaxLength(100);
            entity.Property(e => e.DienThoai).HasMaxLength(15);
            entity.Property(e => e.HoTenNhanVien).HasMaxLength(60);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");

            entity.HasOne(d => d.MaBangCapNavigation).WithMany(p => p.Nhanviens)
                .HasForeignKey(d => d.MaBangCap)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__NHANVIEN__MaBang__3B75D760");
        });

        modelBuilder.Entity<Phieumuonsach>(entity =>
        {
            entity.HasKey(e => e.MaPhieuMuon).HasName("PK__PHIEUMUO__C4C822226F889723");

            entity.ToTable("PHIEUMUONSACH");

            entity.Property(e => e.NgayMuon)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.Phieumuonsaches)
                .HasForeignKey(d => d.MaDocGia)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__PHIEUMUON__MaDoc__44FF419A");
        });

        modelBuilder.Entity<Phieuthutien>(entity =>
        {
            entity.HasKey(e => e.MaPhieuThuTien).HasName("PK__PHIEUTHU__693EDBC8642DBB6B");

            entity.ToTable("PHIEUTHUTIEN");

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.Phieuthutiens)
                .HasForeignKey(d => d.MaDocGia)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__PHIEUTHUT__MaDoc__4BAC3F29");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.Phieuthutiens)
                .HasForeignKey(d => d.MaNhanVien)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__PHIEUTHUT__MaNha__4CA06362");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__SACH__B235742DC019CFB7");

            entity.ToTable("SACH");

            entity.Property(e => e.NgayNhap)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NhaXuatBan).HasMaxLength(60);
            entity.Property(e => e.TacGia).HasMaxLength(60);
            entity.Property(e => e.TenSach).HasMaxLength(100);

            entity.HasMany(d => d.MaPhieuMuons).WithMany(p => p.MaSaches)
                .UsingEntity<Dictionary<string, object>>(
                    "Chitietphieumuon",
                    r => r.HasOne<Phieumuonsach>().WithMany()
                        .HasForeignKey("MaPhieuMuon")
                        .HasConstraintName("FK__CHITIETPH__MaPhi__48CFD27E"),
                    l => l.HasOne<Sach>().WithMany()
                        .HasForeignKey("MaSach")
                        .HasConstraintName("FK__CHITIETPH__MaSac__47DBAE45"),
                    j =>
                    {
                        j.HasKey("MaSach", "MaPhieuMuon");
                        j.ToTable("CHITIETPHIEUMUON");
                    });
        });

        modelBuilder.Entity<Thamso>(entity =>
        {
            entity.HasKey(e => e.TenThamSo).HasName("PK__THAMSO__A49B1359CEC6C996");

            entity.ToTable("THAMSO");

            entity.Property(e => e.TenThamSo).HasMaxLength(40);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

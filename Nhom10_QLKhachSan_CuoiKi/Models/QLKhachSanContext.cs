using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Nhom10_QLKhachSan_CuoiKi.Models;

public partial class QLKhachSanContext : DbContext
{
    public QLKhachSanContext()
    {
    }

    public QLKhachSanContext(DbContextOptions<QLKhachSanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChitietDp> ChitietDps { get; set; }

    public virtual DbSet<Datphong> Datphongs { get; set; }

    public virtual DbSet<Dichvu> Dichvus { get; set; }

    public virtual DbSet<Hoadon> Hoadons { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Khuyenmai> Khuyenmais { get; set; }

    public virtual DbSet<Loaiphong> Loaiphongs { get; set; }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    public virtual DbSet<Phong> Phongs { get; set; }

    public virtual DbSet<SudungDv> SudungDvs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=THANHLAMHET\\SQLEXPRESS;Database=QLKhachSan;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChitietDp>(entity =>
        {
            entity.HasKey(e => e.MaCtdp).HasName("PK__CHITIET___1E4E40F816BF0F35");

            entity.ToTable("CHITIET_DP");

            entity.Property(e => e.MaCtdp).HasColumnName("MaCTDP");
            entity.Property(e => e.GiaThucTe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaDp).HasColumnName("MaDP");
            entity.Property(e => e.NgayNhanDk)
                .HasColumnType("datetime")
                .HasColumnName("NgayNhanDK");
            entity.Property(e => e.NgayTraDk)
                .HasColumnType("datetime")
                .HasColumnName("NgayTraDK");

            entity.HasOne(d => d.MaDpNavigation).WithMany(p => p.ChitietDps)
                .HasForeignKey(d => d.MaDp)
                .HasConstraintName("FK__CHITIET_DP__MaDP__49C3F6B7");

            entity.HasOne(d => d.MaPhongNavigation).WithMany(p => p.ChitietDps)
                .HasForeignKey(d => d.MaPhong)
                .HasConstraintName("FK__CHITIET_D__MaPho__4AB81AF0");
        });

        modelBuilder.Entity<Datphong>(entity =>
        {
            entity.HasKey(e => e.MaDp).HasName("PK__DATPHONG__272586693C9ED506");

            entity.ToTable("DATPHONG");

            entity.Property(e => e.MaDp).HasColumnName("MaDP");
            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.NgayDat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TienCoc).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.Datphongs)
                .HasForeignKey(d => d.MaKh)
                .HasConstraintName("FK__DATPHONG__MaKH__45F365D3");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Datphongs)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__DATPHONG__MaNV__46E78A0C");
        });

        modelBuilder.Entity<Dichvu>(entity =>
        {
            entity.HasKey(e => e.MaDv).HasName("PK__DICHVU__27258657F5A3D338");

            entity.ToTable("DICHVU");

            entity.Property(e => e.MaDv).HasColumnName("MaDV");
            entity.Property(e => e.DonViTinh).HasMaxLength(20);
            entity.Property(e => e.GiaDv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GiaDV");
            entity.Property(e => e.TenDv)
                .HasMaxLength(100)
                .HasColumnName("TenDV");
        });

        modelBuilder.Entity<Hoadon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HOADON__2725A6E07D4C5CD6");

            entity.ToTable("HOADON");

            entity.Property(e => e.MaHd).HasColumnName("MaHD");
            entity.Property(e => e.MaDp).HasColumnName("MaDP");
            entity.Property(e => e.MaKm).HasColumnName("MaKM");
            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.NgayTt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("NgayTT");
            entity.Property(e => e.PhuThu)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ThanhTien).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TienGiam)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.MaDpNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaDp)
                .HasConstraintName("FK__HOADON__MaDP__5535A963");

            entity.HasOne(d => d.MaKmNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaKm)
                .HasConstraintName("FK__HOADON__MaKM__571DF1D5");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.Hoadons)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK__HOADON__MaNV__5629CD9C");
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KHACHHAN__2725CF1E01C07D4D");

            entity.ToTable("KHACHHANG");

            entity.HasIndex(e => e.Cccd, "UQ__KHACHHAN__A955A0AA080B4A09").IsUnique();

            entity.Property(e => e.MaKh).HasColumnName("MaKH");
            entity.Property(e => e.Cccd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Khuyenmai>(entity =>
        {
            entity.HasKey(e => e.MaKm).HasName("PK__KHUYENMA__2725CF15492DEB33");

            entity.ToTable("KHUYENMAI");

            entity.Property(e => e.MaKm).HasColumnName("MaKM");
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            entity.Property(e => e.PhanTramGiam).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.TenKm)
                .HasMaxLength(100)
                .HasColumnName("TenKM");
        });

        modelBuilder.Entity<Loaiphong>(entity =>
        {
            entity.HasKey(e => e.MaLoai).HasName("PK__LOAIPHON__730A575950EF4C63");

            entity.ToTable("LOAIPHONG");

            entity.Property(e => e.GiaMacDinh).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TenLoai).HasMaxLength(50);
        });

        modelBuilder.Entity<Nhanvien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NHANVIEN__2725D70ACAE9CC11");

            entity.ToTable("NHANVIEN");

            entity.Property(e => e.MaNv).HasColumnName("MaNV");
            entity.Property(e => e.ChucVu).HasMaxLength(50);
            entity.Property(e => e.HinhAnh)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.TrangThai).HasMaxLength(50);
        });

        modelBuilder.Entity<Phong>(entity =>
        {
            entity.HasKey(e => e.MaPhong).HasName("PK__PHONG__20BD5E5BCC17965D");

            entity.ToTable("PHONG");

            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.TenPhong).HasMaxLength(50);
            entity.Property(e => e.TrangThai).HasMaxLength(50);

            entity.HasOne(d => d.MaLoaiNavigation).WithMany(p => p.Phongs)
                .HasForeignKey(d => d.MaLoai)
                .HasConstraintName("FK__PHONG__MaLoai__4222D4EF");
        });

        modelBuilder.Entity<SudungDv>(entity =>
        {
            entity.HasKey(e => e.MaSd).HasName("PK__SUDUNG_D__27250808A6BAD626");

            entity.ToTable("SUDUNG_DV");

            entity.Property(e => e.MaSd).HasColumnName("MaSD");
            entity.Property(e => e.DonGiaThucTe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MaCtdp).HasColumnName("MaCTDP");
            entity.Property(e => e.MaDv).HasColumnName("MaDV");
            entity.Property(e => e.ThoiGianGoi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.MaCtdpNavigation).WithMany(p => p.SudungDvs)
                .HasForeignKey(d => d.MaCtdp)
                .HasConstraintName("FK__SUDUNG_DV__MaCTD__4E88ABD4");

            entity.HasOne(d => d.MaDvNavigation).WithMany(p => p.SudungDvs)
                .HasForeignKey(d => d.MaDv)
                .HasConstraintName("FK__SUDUNG_DV__MaDV__4F7CD00D");
        });

        OnModelCreatingPartial(modelBuilder);
    }


	partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

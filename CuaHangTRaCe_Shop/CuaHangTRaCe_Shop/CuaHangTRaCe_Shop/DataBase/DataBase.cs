using CuaHangTRaCe_Shop.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace CuaHangTRaCe_Shop.DataBase
{
    public class DataBase : DbContext
    {
        public DataBase()
            : base("name=DataBase")
        {
        }

        public virtual DbSet<BASE_ID> BASE_IDs { get; set; }
        public virtual DbSet<ChatLieu> ChatLieus  { get; set; }
        public virtual DbSet<ChiTietDonBan> ChiTietDonBans  { get; set; }
        public virtual DbSet<ChiTietDonNhap> ChiTietDonNhaps { get; set; }
        public virtual DbSet<CPU> CPUs { get; set; }
        public virtual DbSet<DonBan> DonBans { get; set; }
        public virtual DbSet<DonNhap> DonNhaps { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Kho> Khos { get; set; }
        public virtual DbSet<LapTop> LapTops { get; set; }
        public virtual DbSet<LoaiLapTop> LoaiLapTops { get; set; }
        public virtual DbSet<LoaiPhuKien> LoaiPhuKiens { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<PhuKien> PhuKiens { get; set; }
        public virtual DbSet<Ram> Rams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThongKe> ThongKes { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }

    }
}
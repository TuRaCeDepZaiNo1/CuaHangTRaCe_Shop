namespace CuaHangTRaCe_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BASE_ID",
                c => new
                    {
                        ID_BASE = c.Int(nullable: false, identity: true),
                        TinhTrang = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_BASE);
            
            CreateTable(
                "dbo.Laptop",
                c => new
                    {
                        ID_Laptop = c.String(nullable: false, maxLength: 128),
                        TenLapTop = c.String(nullable: false, maxLength: 4000),
                        GiaBan = c.Double(nullable: false),
                        NgaySanXuat = c.DateTime(nullable: false),
                        HinhAnh = c.Binary(),
                        ID_ThuongHieu = c.String(nullable: false, maxLength: 128),
                        ID_ChatLieu = c.String(nullable: false, maxLength: 128),
                        ID_BASE = c.Int(nullable: false),
                        ID_Ram = c.String(nullable: false, maxLength: 128),
                        ID_CPU = c.String(nullable: false, maxLength: 128),
                        ID_LoaiLapTop = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_Laptop)
                .ForeignKey("dbo.BASE_ID", t => t.ID_BASE, cascadeDelete: true)
                .ForeignKey("dbo.ChatLieu", t => t.ID_ChatLieu, cascadeDelete: true)
                .ForeignKey("dbo.CPU", t => t.ID_CPU, cascadeDelete: true)
                .ForeignKey("dbo.LoaiLaptop", t => t.ID_LoaiLapTop, cascadeDelete: true)
                .ForeignKey("dbo.Ram", t => t.ID_Ram, cascadeDelete: true)
                .ForeignKey("dbo.ThuongHieu", t => t.ID_ThuongHieu, cascadeDelete: true)
                .Index(t => t.ID_ThuongHieu)
                .Index(t => t.ID_ChatLieu)
                .Index(t => t.ID_BASE)
                .Index(t => t.ID_Ram)
                .Index(t => t.ID_CPU)
                .Index(t => t.ID_LoaiLapTop);
            
            CreateTable(
                "dbo.ChatLieu",
                c => new
                    {
                        ID_ChatLieu = c.String(nullable: false, maxLength: 128),
                        TenChatLieu = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.ID_ChatLieu);
            
            CreateTable(
                "dbo.CPU",
                c => new
                    {
                        ID_CPU = c.String(nullable: false, maxLength: 128),
                        TenCPU = c.String(nullable: false, maxLength: 4000),
                        SoLoi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_CPU);
            
            CreateTable(
                "dbo.LoaiLaptop",
                c => new
                    {
                        ID_LoaiLaptop = c.String(nullable: false, maxLength: 128),
                        TenLoai = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_LoaiLaptop);
            
            CreateTable(
                "dbo.Ram",
                c => new
                    {
                        ID_Ram = c.String(nullable: false, maxLength: 128),
                        Dunglượnggb = c.Int(name: "Dung lượng(gb)", nullable: false),
                        LoaiRam = c.String(),
                    })
                .PrimaryKey(t => t.ID_Ram);
            
            CreateTable(
                "dbo.ThuongHieu",
                c => new
                    {
                        ID_ThuongHieu = c.String(nullable: false, maxLength: 128),
                        TenThuongHieu = c.String(nullable: false, maxLength: 4000),
                        HinhAnh = c.Binary(),
                    })
                .PrimaryKey(t => t.ID_ThuongHieu);
            
            CreateTable(
                "dbo.PhuKien",
                c => new
                    {
                        Id_PhuKien = c.String(nullable: false, maxLength: 128),
                        TenPhuKien = c.String(nullable: false, maxLength: 4000),
                        GiaBan = c.Double(nullable: false),
                        MoTa = c.String(nullable: false, maxLength: 4000),
                        HinhAnh = c.Binary(nullable: false),
                        ID_BASE = c.Int(nullable: false),
                        ID_LoaiPK = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id_PhuKien)
                .ForeignKey("dbo.BASE_ID", t => t.ID_BASE, cascadeDelete: true)
                .ForeignKey("dbo.LoaiPhuKien", t => t.ID_LoaiPK)
                .Index(t => t.ID_BASE)
                .Index(t => t.ID_LoaiPK);
            
            CreateTable(
                "dbo.LoaiPhuKien",
                c => new
                    {
                        ID_LoaiPhuKien = c.String(nullable: false, maxLength: 128),
                        TenLoaiPK = c.String(nullable: false, maxLength: 4000),
                    })
                .PrimaryKey(t => t.ID_LoaiPhuKien);
            
            CreateTable(
                "dbo.ChiTietDonBan",
                c => new
                    {
                        ID_ChiTietDonBan = c.String(nullable: false, maxLength: 128),
                        SoLuong = c.Int(nullable: false),
                        TongGiaSanPham = c.Double(nullable: false),
                        ID_DonBan = c.String(maxLength: 128),
                        ID_SanPham = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_ChiTietDonBan)
                .ForeignKey("dbo.DonBan", t => t.ID_DonBan)
                .ForeignKey("dbo.Laptop", t => t.ID_SanPham)
                .ForeignKey("dbo.PhuKien", t => t.ID_SanPham)
                .Index(t => t.ID_DonBan)
                .Index(t => t.ID_SanPham);
            
            CreateTable(
                "dbo.DonBan",
                c => new
                    {
                        ID_DonBan = c.String(nullable: false, maxLength: 128),
                        NgayBan = c.DateTime(nullable: false),
                        TongGiaTriDB = c.Double(nullable: false),
                        SDT = c.String(maxLength: 128),
                        ID_NguoiDung = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_DonBan)
                .ForeignKey("dbo.KhachHang", t => t.SDT)
                .ForeignKey("dbo.NguoiDung", t => t.ID_NguoiDung)
                .Index(t => t.SDT)
                .Index(t => t.ID_NguoiDung);
            
            CreateTable(
                "dbo.KhachHang",
                c => new
                    {
                        SDT = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(nullable: false),
                        TongGiaTriMua = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.SDT);
            
            CreateTable(
                "dbo.NguoiDung",
                c => new
                    {
                        ID_NguoiDung = c.String(nullable: false, maxLength: 128),
                        HoTen = c.String(nullable: false, maxLength: 255),
                        NgaySinh = c.DateTime(nullable: false),
                        DiaChi = c.String(nullable: false, maxLength: 2000),
                        HinhAnh = c.Binary(),
                        ChucNang = c.String(),
                        Luong = c.Double(nullable: false),
                        NgayVaoLam = c.DateTime(nullable: false),
                        ID_TaiKhoan = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_NguoiDung)
                .ForeignKey("dbo.TaiKhoan", t => t.ID_TaiKhoan, cascadeDelete: true)
                .Index(t => t.ID_TaiKhoan);
            
            CreateTable(
                "dbo.DonNhap",
                c => new
                    {
                        ID_DonNhap = c.String(nullable: false, maxLength: 128),
                        NgayNhap = c.DateTime(nullable: false),
                        ID_NguoiDung = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_DonNhap)
                .ForeignKey("dbo.NguoiDung", t => t.ID_NguoiDung)
                .Index(t => t.ID_NguoiDung);
            
            CreateTable(
                "dbo.TaiKhoan",
                c => new
                    {
                        ID_TaiKhoan = c.String(nullable: false, maxLength: 128),
                        TenTaikhoan = c.String(nullable: false),
                        MatKhau = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        SDT = c.String(nullable: false),
                        ID_Quyen = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_TaiKhoan)
                .ForeignKey("dbo.PhanQuyen", t => t.ID_Quyen, cascadeDelete: true)
                .Index(t => t.ID_Quyen);
            
            CreateTable(
                "dbo.PhanQuyen",
                c => new
                    {
                        ID_PhanQuyen = c.String(nullable: false, maxLength: 128),
                        MoTaQuyen = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID_PhanQuyen);
            
            CreateTable(
                "dbo.ChiTietDonNhap",
                c => new
                    {
                        ID_ChiTietDonNhap = c.String(nullable: false, maxLength: 128),
                        SoLuong = c.Int(nullable: false),
                        ID_DonNhap = c.String(maxLength: 128),
                        Id_SanPham = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_ChiTietDonNhap)
                .ForeignKey("dbo.DonNhap", t => t.ID_DonNhap)
                .ForeignKey("dbo.Laptop", t => t.Id_SanPham)
                .ForeignKey("dbo.PhuKien", t => t.Id_SanPham)
                .Index(t => t.ID_DonNhap)
                .Index(t => t.Id_SanPham);
            
            CreateTable(
                "dbo.Kho",
                c => new
                    {
                        ID_Kho = c.Int(nullable: false, identity: true),
                        SoLuongTonKho = c.Int(nullable: false),
                        ID_SanPham = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_Kho)
                .ForeignKey("dbo.Laptop", t => t.ID_SanPham)
                .ForeignKey("dbo.PhuKien", t => t.ID_SanPham)
                .Index(t => t.ID_SanPham);
            
            CreateTable(
                "dbo.ThongKe",
                c => new
                    {
                        ID_ThongKe = c.String(nullable: false, maxLength: 128),
                        ThoiGianDau = c.DateTime(nullable: false),
                        ThoiGianCuoi = c.DateTime(nullable: false),
                        TongDoanhThu = c.Double(nullable: false),
                        ID_DonBan = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID_ThongKe)
                .ForeignKey("dbo.DonBan", t => t.ID_DonBan)
                .Index(t => t.ID_DonBan);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ThongKe", "ID_DonBan", "dbo.DonBan");
            DropForeignKey("dbo.Kho", "ID_SanPham", "dbo.PhuKien");
            DropForeignKey("dbo.Kho", "ID_SanPham", "dbo.Laptop");
            DropForeignKey("dbo.ChiTietDonNhap", "Id_SanPham", "dbo.PhuKien");
            DropForeignKey("dbo.ChiTietDonNhap", "Id_SanPham", "dbo.Laptop");
            DropForeignKey("dbo.ChiTietDonNhap", "ID_DonNhap", "dbo.DonNhap");
            DropForeignKey("dbo.ChiTietDonBan", "ID_SanPham", "dbo.PhuKien");
            DropForeignKey("dbo.ChiTietDonBan", "ID_SanPham", "dbo.Laptop");
            DropForeignKey("dbo.ChiTietDonBan", "ID_DonBan", "dbo.DonBan");
            DropForeignKey("dbo.NguoiDung", "ID_TaiKhoan", "dbo.TaiKhoan");
            DropForeignKey("dbo.TaiKhoan", "ID_Quyen", "dbo.PhanQuyen");
            DropForeignKey("dbo.DonNhap", "ID_NguoiDung", "dbo.NguoiDung");
            DropForeignKey("dbo.DonBan", "ID_NguoiDung", "dbo.NguoiDung");
            DropForeignKey("dbo.DonBan", "SDT", "dbo.KhachHang");
            DropForeignKey("dbo.PhuKien", "ID_LoaiPK", "dbo.LoaiPhuKien");
            DropForeignKey("dbo.PhuKien", "ID_BASE", "dbo.BASE_ID");
            DropForeignKey("dbo.Laptop", "ID_ThuongHieu", "dbo.ThuongHieu");
            DropForeignKey("dbo.Laptop", "ID_Ram", "dbo.Ram");
            DropForeignKey("dbo.Laptop", "ID_LoaiLapTop", "dbo.LoaiLaptop");
            DropForeignKey("dbo.Laptop", "ID_CPU", "dbo.CPU");
            DropForeignKey("dbo.Laptop", "ID_ChatLieu", "dbo.ChatLieu");
            DropForeignKey("dbo.Laptop", "ID_BASE", "dbo.BASE_ID");
            DropIndex("dbo.ThongKe", new[] { "ID_DonBan" });
            DropIndex("dbo.Kho", new[] { "ID_SanPham" });
            DropIndex("dbo.ChiTietDonNhap", new[] { "Id_SanPham" });
            DropIndex("dbo.ChiTietDonNhap", new[] { "ID_DonNhap" });
            DropIndex("dbo.TaiKhoan", new[] { "ID_Quyen" });
            DropIndex("dbo.DonNhap", new[] { "ID_NguoiDung" });
            DropIndex("dbo.NguoiDung", new[] { "ID_TaiKhoan" });
            DropIndex("dbo.DonBan", new[] { "ID_NguoiDung" });
            DropIndex("dbo.DonBan", new[] { "SDT" });
            DropIndex("dbo.ChiTietDonBan", new[] { "ID_SanPham" });
            DropIndex("dbo.ChiTietDonBan", new[] { "ID_DonBan" });
            DropIndex("dbo.PhuKien", new[] { "ID_LoaiPK" });
            DropIndex("dbo.PhuKien", new[] { "ID_BASE" });
            DropIndex("dbo.Laptop", new[] { "ID_LoaiLapTop" });
            DropIndex("dbo.Laptop", new[] { "ID_CPU" });
            DropIndex("dbo.Laptop", new[] { "ID_Ram" });
            DropIndex("dbo.Laptop", new[] { "ID_BASE" });
            DropIndex("dbo.Laptop", new[] { "ID_ChatLieu" });
            DropIndex("dbo.Laptop", new[] { "ID_ThuongHieu" });
            DropTable("dbo.ThongKe");
            DropTable("dbo.Kho");
            DropTable("dbo.ChiTietDonNhap");
            DropTable("dbo.PhanQuyen");
            DropTable("dbo.TaiKhoan");
            DropTable("dbo.DonNhap");
            DropTable("dbo.NguoiDung");
            DropTable("dbo.KhachHang");
            DropTable("dbo.DonBan");
            DropTable("dbo.ChiTietDonBan");
            DropTable("dbo.LoaiPhuKien");
            DropTable("dbo.PhuKien");
            DropTable("dbo.ThuongHieu");
            DropTable("dbo.Ram");
            DropTable("dbo.LoaiLaptop");
            DropTable("dbo.CPU");
            DropTable("dbo.ChatLieu");
            DropTable("dbo.Laptop");
            DropTable("dbo.BASE_ID");
        }
    }
}

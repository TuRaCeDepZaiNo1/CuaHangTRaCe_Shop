using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("NguoiDung")]
    public class NguoiDung
    {
        [Key]
        public string ID_NguoiDung {  get; set; }
        [Required]
        [MaxLength(255)]
        [Column(TypeName = "nvarchar")]
        public string HoTen {  get; set; }
        [Required]
        public DateTime NgaySinh { get; set; }
        [Required]
        [MaxLength(2000)]
        public string DiaChi {  get; set; }
        public byte[] HinhAnh { get; set; }
        public string ChucNang { get; set; }
        [Required]
        public double Luong {  get; set; }
        [Required]
        public DateTime NgayVaoLam { get; set; }
        [Required]
        public string ID_TaiKhoan {  get; set; }
        [ForeignKey("ID_TaiKhoan")]
        public virtual TaiKhoan TaiKhoan { get; set;}
        public virtual ICollection<DonNhap> DonNhaps { get; set; }

        public virtual ICollection<DonBan> DonBans { get; set; }
    }
}

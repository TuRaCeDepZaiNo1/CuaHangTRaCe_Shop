using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("ChiTietDonNhap")]
    public class ChiTietDonNhap
    {
        [Key]
        public string ID_ChiTietDonNhap { get; set; }
        [Required]
        public int SoLuong {  get; set; }
        public string ID_DonNhap {  get; set; }
        [ForeignKey("ID_DonNhap")]
        public virtual DonNhap DonNhap { get; set; }
        public string Id_SanPham { get; set; }
        [ForeignKey("Id_SanPham")]
        public virtual LapTop LapTop { get; set; }
        [ForeignKey("Id_SanPham")]
        public virtual PhuKien PhuKien { get; set; }

    }
}

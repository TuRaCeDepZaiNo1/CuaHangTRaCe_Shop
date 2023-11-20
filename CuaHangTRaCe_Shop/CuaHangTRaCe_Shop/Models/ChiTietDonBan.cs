using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("ChiTietDonBan")]
    public class ChiTietDonBan
    {
        [Key]
        public string ID_ChiTietDonBan {  get; set; }
        [Required]
        public int SoLuong {  get; set; }
        [Required]
        public double TongGiaSanPham {  get; set; }
        public string ID_DonBan {  get; set; }
        [ForeignKey("ID_DonBan")]
        public virtual DonBan DonBan { get; set; }

        public string ID_SanPham { get;set; }
        [ForeignKey("ID_SanPham")]
        public virtual LapTop LapTop { get; set; }
        [ForeignKey("ID_SanPham")]
        public virtual PhuKien PhuKien { get; set; }
    }
}

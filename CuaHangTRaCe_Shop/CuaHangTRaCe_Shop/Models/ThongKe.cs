using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("ThongKe")]
    public class ThongKe
    {
        [Key]
        public string ID_ThongKe {  get; set; }
        [Required]
        public DateTime ThoiGianDau { get; set; }
        [Required]
        public DateTime ThoiGianCuoi { get; set; }
        [Required]
        public double TongDoanhThu {  get; set; } 

        public string ID_DonBan {  get; set; }
        [ForeignKey("ID_DonBan")]
        public virtual DonBan DonBan { get; set; }
    }
}

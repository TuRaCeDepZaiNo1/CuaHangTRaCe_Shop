using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("DonBan")]
    public class DonBan
    {
        [Key]
        public string ID_DonBan {  get; set; }
        [Required]
        public DateTime NgayBan { get; set; }
        [Required]
        public double TongGiaTriDB {  get; set; }
        public string SDT {  get; set; }
        [ForeignKey("SDT")]
        public virtual KhachHang KhachHang { get; set; }    
        public string ID_NguoiDung {  get; set; }
        [ForeignKey("ID_NguoiDung")]
        public virtual NguoiDung NguoiDung { get; set;}
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public string SDT {  get; set; }
        [Required]
        public string HoTen { get; set; }
        [Required]
        public double TongGiaTriMua {  get; set; }
    }
}

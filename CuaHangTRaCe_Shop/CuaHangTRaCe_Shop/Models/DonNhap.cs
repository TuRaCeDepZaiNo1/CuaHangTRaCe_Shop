using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("DonNhap")]   
    
    public class DonNhap
    {
        [Key] 
        public string ID_DonNhap { get; set; }
        [Required]
        public DateTime NgayNhap { get; set; }
        public string ID_NguoiDung { get; set; }
        [ForeignKey("ID_NguoiDung")]
        public virtual NguoiDung NguoiDung { get; set; }
    }
}

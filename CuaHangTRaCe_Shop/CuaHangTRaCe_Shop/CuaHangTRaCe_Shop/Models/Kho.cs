using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("Kho")]
    public class Kho
    {
        [Key]
        public int ID_Kho { get; set; }
        [Required]
        public int SoLuongTonKho {  get; set; }
        public string ID_SanPham {  get; set; }
        [ForeignKey("ID_SanPham")]
        public virtual LapTop LapTop { get; set; }
        [ForeignKey("ID_SanPham")]
        public virtual PhuKien PhuKien { get; set;}
    }
}

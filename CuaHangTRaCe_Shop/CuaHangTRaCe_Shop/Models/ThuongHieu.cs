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
    [Table("ThuongHieu")]
    public class ThuongHieu
    {
        [Key]
        public string ID_ThuongHieu { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string TenThuongHieu { get; set; }
        public byte[] HinhAnh { get; set; }
        public virtual ICollection<LapTop> LapTop { get; set; }
    }
}

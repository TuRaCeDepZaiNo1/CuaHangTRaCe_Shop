using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("LoaiLaptop")]
    public class LoaiLapTop
    {
        [Key]
        public string ID_LoaiLaptop { get; set; }
        [Required]
        public string TenLoai { get; set; }
        public virtual ICollection<LapTop> LapTops { get; set; }
    }
}

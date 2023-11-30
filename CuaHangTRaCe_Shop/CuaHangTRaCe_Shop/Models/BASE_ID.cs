using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("BASE_ID")]
    public class BASE_ID
    {
        [Key]
        public int ID_BASE { get; set; }
        [Required]
        public string TinhTrang {  get; set; }
        public virtual ICollection<LapTop> LapTops { get; set; }
        public virtual ICollection<PhuKien> PhuKien { get; set;}
    }
}

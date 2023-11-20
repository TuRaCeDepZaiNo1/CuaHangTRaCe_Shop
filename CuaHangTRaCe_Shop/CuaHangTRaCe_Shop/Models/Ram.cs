using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("Ram")]
    public class Ram
    {
        [Key]
        public string ID_Ram { get; set; }
        [Column("Dung lượng(gb)")]
        public int DungLuong {  get; set; }
        public string LoaiRam {  get; set; }
        public virtual ICollection<LapTop> LapTop { get; set; }
    }
}

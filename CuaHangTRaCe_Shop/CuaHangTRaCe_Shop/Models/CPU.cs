using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("CPU")]
    public class CPU
    {
        [Key]
        public string ID_CPU {  get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string TenCPU { get; set; }
        [Required]
        public virtual ICollection<LapTop> LapTop { get; set; }
    }
}

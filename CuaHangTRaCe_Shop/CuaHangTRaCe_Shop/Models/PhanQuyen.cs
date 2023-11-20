using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("PhanQuyen")]
    public class PhanQuyen
    {
        [Key]
        public string ID_PhanQuyen { get; set; }
        [Required]
        public string MoTaQuyen { get; set; }
    }
}

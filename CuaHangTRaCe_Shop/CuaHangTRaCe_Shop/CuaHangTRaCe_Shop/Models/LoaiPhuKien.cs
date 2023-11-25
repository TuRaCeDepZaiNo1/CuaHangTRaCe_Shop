using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("LoaiPhuKien")]
    public class LoaiPhuKien
    {
        [Key]  
        public string ID_LoaiPhuKien {  get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string TenLoaiPK {  get; set; }
        public virtual ICollection<PhuKien> PhuKien { get; set; }  
    }
}

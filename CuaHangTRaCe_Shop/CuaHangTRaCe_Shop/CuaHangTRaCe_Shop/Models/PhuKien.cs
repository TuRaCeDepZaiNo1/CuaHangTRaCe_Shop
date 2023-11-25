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
    [Table("PhuKien")]
    public class PhuKien
    {
        [Key] 
        public string Id_PhuKien { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string TenPhuKien { get; set; }
        [Required]
        public double GiaBan {  get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string MoTa {  get; set; }
        public byte[] HinhAnh { get; set; }
        public int ID_BASE { get; set; }
        [ForeignKey("ID_BASE")]
        public virtual BASE_ID BASE_ID { get; set; }
        public string ID_LoaiPK {  get; set; }
        [ForeignKey("ID_LoaiPK")]
        public virtual LoaiPhuKien LoaiPhuKien { get; set;}

    }
}

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
    [Table("Laptop")]
    public class LapTop
    {
        [Key]
        public string ID_Laptop { get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string TenLapTop {  get; set; }
        [Required]
        public double GiaBan {  get; set; }
        [Required]
        public DateTime NgaySanXuat { get; set; }
        public byte[] HinhAnh {  get; set; }
        [Required]
        public string ID_ThuongHieu {  get; set; }
        [ForeignKey("ID_ThuongHieu")]
        public virtual ThuongHieu ThuongHieu { get; set; }
        [Required]
        public string ID_ChatLieu { get; set; }
        [ForeignKey("ID_ChatLieu")]
        public virtual ChatLieu ChatLieu { get; set; }
        [Required]
        public int ID_BASE { get; set; }
        [ForeignKey("ID_BASE")]
        public virtual BASE_ID BASE_ID { get; set; }
        [Required]
        public string ID_Ram {  get; set; }
        [ForeignKey("ID_Ram")]
        public virtual Ram Ram { get; set; }
        [Required]
        public string ID_CPU {  get; set; }
        [ForeignKey("ID_CPU")]
        public virtual CPU CPU { get; set; }
        [Required]
        public string ID_LoaiLapTop {  get; set; }
        [ForeignKey("ID_LoaiLapTop")]
        public virtual LoaiLapTop LoaiLapTop { get; set;}
    }
}

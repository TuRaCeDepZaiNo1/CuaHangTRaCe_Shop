using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("TaiKhoan")]
    public class TaiKhoan
    {
        [Key]
        [Column(TypeName = "char")]
        public string ID_TaiKhoan {  get; set; }
        [Required]
        public string TenTaikhoan { get; set; }
        [Required]
        public string MatKhau {  get; set; }
        [Required]
        public string Email {  get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        public string ID_Quyen {  get; set; }
        [ForeignKey("ID_Quyen")]
        public virtual PhanQuyen PhanQuyen { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangTRaCe_Shop.Models
{
    [Table("ChatLieu")]
    public class ChatLieu
    {
        [Key]
        public string ID_ChatLieu {  get; set; }
        [Required]
        [Column(TypeName = "nvarchar")]
        public string TenChatLieu { get; set; }
        public virtual ICollection<LapTop> LapTop { get; set; }

    }
}

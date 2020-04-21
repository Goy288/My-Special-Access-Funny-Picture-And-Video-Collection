using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace My_Special_Access_Funny_Picture_And_Video_Collection.Models
{
    public class Media
    {

        private static readonly string[] VideoTypes = new string[] { "mp4", "webm", "ogg" };
        private static readonly string[] ImageTypes = new string[] { "jpeg", "jpg", "png", "gif" };

        [Key]
        public int MediaID { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR(260)")]
        [StringLength(260)]
        public string FileName { get; set; }

        [Required]
        [StringLength(64)]
        public string FileType { get; set; }

        [Required]
        public bool IsVideo { get; set; }
    }
}

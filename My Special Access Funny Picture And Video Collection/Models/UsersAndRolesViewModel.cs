using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace My_Special_Access_Funny_Picture_And_Video_Collection.Models
{
    // Probably won't be used lmao.
    public class UsersAndRolesViewModel
    {
        [Key]
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}

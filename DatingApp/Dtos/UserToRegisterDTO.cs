using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Dtos
{
    public class UserToRegisterDTO
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8,ErrorMessage ="Password should contains 4 to 8 caracters",MinimumLength =4)]
        public string Password { get; set; }
    }
}

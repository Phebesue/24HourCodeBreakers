using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassB.Models.Users
{
    public class UserCreate
    {
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}

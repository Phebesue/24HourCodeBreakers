using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassB.Data
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "User Name is required")]
        [Display(Name = "User Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}

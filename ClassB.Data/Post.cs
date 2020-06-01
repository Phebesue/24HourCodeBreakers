using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassB.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }


        [Required]
        public Guid UserId { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(1000, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Post Title")]
        public string Title { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(1000, ErrorMessage = "There are too many characters in this field.")]
        [Display(Name = "Post Contents")]
        public string PostText { get; set; }

        [Required]
        public User PostAuthor { get; set; }

        [Required]
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        //  public DateTimeOffset ModifiedUtc { get; set; }
    }
}

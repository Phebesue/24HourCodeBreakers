using ClassB.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassB.Models.Post
{
    public class PostListItem
    {
        public int PostId { get; set; }
        [Display(Name = "Post Title")]
        public string PostTitle { get; set; }
        [Display(Name = "Post Contents")]
        public string PostText { get; set; }
        public User Author { get; set; }
        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

    }
}

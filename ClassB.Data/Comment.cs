using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassB.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }
        [ForeignKey("Author")]
        [Required]
        public Guid UserId { get; set; }
        public virtual User Author { get; set; }
        [ForeignKey("PostId")]
        [Required]
        public int PostId { get; set; }
        public virtual Post CommentPost { get; set; }
        //Post CommentPost
    }
}

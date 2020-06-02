using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassB.Data
{
    public class Like
    {
        [Key]
        public int LikeId { get; set; }
        [ForeignKey("Author")]
        [Required]
        public Guid? UserId { get; set; }
        public virtual User Author { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        [ForeignKey("Comment")]
        public int? CommentId { get; set; }
        public virtual Comment Comment { get; set; }
    }
}

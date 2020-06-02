using ClassB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassB.Models
{
    public class LikeListItem
    {
        public User Author { get; set; }
        public Post Post { get; set; }
        public Comment Comment { get; set; }
    }
}

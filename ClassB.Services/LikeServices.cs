using ClassB.Data;
using ClassB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassB.Services
{
    public class LikeService
    {
        private readonly Guid _userId;
        public LikeService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateLike(LikeCreate model)
        {
            var entity =
                new Like()
                {
                    LikeId = model.LikeId,
                    UserId = _userId,
                    Comment = model.Comment,
                    Post = model.Post,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Likes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<LikeListItem> GetLikes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx.Likes
                    .Where(e => e.Author.UserId == _userId)
                    .Select(e => new LikeListItem
                    {
                        Author = e.Author,
                        Comment = e.Comment,
                        Post = e.Post,
                    }
                    );
                return query.ToArray();
            }
        }
    }
}

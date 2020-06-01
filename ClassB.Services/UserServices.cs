using ClassB.Data;
using ClassB.Models.User;
using CodeB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassB.Services
{
    public class UserServices
    {
        private readonly Guid _userId;
        public UserServices(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateUser(UserCreate model)
        {
            var entity =
                new User()
                {
                    UserId = _userId,
                    Name = model.Name,
                    Email = model.Email
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Users.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<UserListItem> GetUser()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Users
                    .Where(e => e.UserId == _userId)
                    .Select(
                        e =>
                        new UserListItem
                        {
                            UserId = e.UserId,
                            Name = e.Name,
                            Email = e.Email
                        }
                        );
                return query.ToArray();
            }
        }
    }
}

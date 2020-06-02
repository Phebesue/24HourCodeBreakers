using ClassB.Models;
using ClassB.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CodeB.Controllers
{
    public class LikeController : ApiController
    {
        private LikeService CreateLikeService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            return new LikeService(userId);
        }
        public IHttpActionResult Get()
        {
            LikeService likeService = CreateLikeService();
            var likes = likeService.GetLikes();
            return Ok(likes);
        }
        public IHttpActionResult Like(LikeCreate like)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var service = CreateLikeService();
            if (!service.CreateLike(like))
                return InternalServerError();
            return Ok();
        }
    }
}

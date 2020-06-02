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
    [Authorize]
    public class CommentController : ApiController
    {
        private CommentService CreateCommentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var noteService = new CommentService(userId);
            return noteService;
        }
        public IHttpActionResult Get()
        {
            CommentService noteService = CreateCommentService();
            var notes = noteService.GetComments();
            return Ok(notes);
        }
        public IHttpActionResult Post(CommentCreate note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCommentService();

            if (!service.CreateComment(note))
                return InternalServerError();

            return Ok();
        }
    }
}

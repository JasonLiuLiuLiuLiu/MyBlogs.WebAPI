using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlogs.DTO;
using MyBlogs.Service;
using MyBlogs.WebAPI.Models;

namespace MyBlogs.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        // GET: api/Wp_comment
        [HttpGet]
        public IEnumerable<CommentResponse> GetWp_comment()
        {
            return _commentService.GetAll();
        }

        // GET: api/Wp_comment/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWp_comment([FromRoute] int id)
        {

            var commentResponse = _commentService.FindById(id);

            if (commentResponse == null)
            {
                return NotFound();
            }

            return Ok(commentResponse);
        }


        // Put: api/Wp_comment
        [HttpPut]
        public async Task<IActionResult> PutWp_comment(CommentRequest request)
        {

            _commentService.Update(request);

            return Ok("更新成功");
        }

        // DELETE: api/Wp_comment/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWp_comment([FromRoute] int id)
        {

            _commentService.Delete(id);

            return Ok("删除成功");
        }

        private bool Wp_commentExists(int id)
        {
            return _commentService.FindById(id) != null;
        }
    }
}
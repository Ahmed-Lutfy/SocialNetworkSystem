using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Social.Application.Service.Interface;
using Social.Application.Shared;
using Social.Domain.Entities;
using Social.Infrastructure.Migrations;

namespace Social.PL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public IPostService _postService { get; set; }
        
        public PostController(IPostService postService)
        {
            _postService = postService;
            
        }
        [HttpGet]
       public async Task<IActionResult> get()
        {
            try
            {
                var posts = await _postService.GetPosts();
                return Ok(ApiResponse<IEnumerable <Post>>.SuccessResponse(posts, "Posts Retreives Successfuly"));
            }
            catch (Exception ex)
            {
                IEnumerable<string> errors = [ex.Message];
                return BadRequest(ApiResponse<Post>.FailResponse("Faild To Load Posts" ,errors));
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> post(Post post)
        {
            try
            {
                var postCreate = await _postService.createPost(post);
                return Ok(ApiResponse<Post>.SuccessResponse(postCreate, "Post Created Successfuly"));
            }
            catch (Exception ex)
            {
                IEnumerable<string> errors = [ex.Message];
                return BadRequest(ApiResponse<Post>.FailResponse("Faild To Create Post", errors));
            }
            
        }
    }
}

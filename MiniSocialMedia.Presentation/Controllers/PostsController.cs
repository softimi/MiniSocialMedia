using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MiniSocialMedia.Presentation.ActionFilters;
using Service.Contracts;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MiniSocialMedia.Presentation.Controllers
{
    [Route("api/users/{userId}/posts")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public PostsController(IServiceManager service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetPostsForUser(Guid userId,
            [FromQuery] PostParameters postParameters)
        {
            var pagedResult = await _service.PostService.GetPostsAsync
                (userId, postParameters, trackChanges: false);

            Response.Headers.Add("X-pagination", 
                JsonSerializer.Serialize(pagedResult.metaData));

            return Ok(pagedResult.posts);
        }

        [HttpGet("recent-posts")]
        public async Task<IActionResult> GetRecentPostsForUser(Guid userId,
            [FromQuery] PostParameters postParameters)
        {
            var followees = 
                await _service.FollowService.GetFolloweesAsync
                (userId, trackChanges: false);

            var pagedResult = await _service.PostService.GetRecentPostsAsync
                (userId, followees, postParameters, trackChanges: false);

            Response.Headers.Add("X-pagination",
                JsonSerializer.Serialize(pagedResult.metaData));

            return Ok(pagedResult.posts);
        }

        [HttpGet("{postId:guid}", Name = "GetPostForUser")]
        public async Task<IActionResult> GetPostForUser(Guid userId, Guid postId)
        {
            var post = await _service.PostService.GetPostAsync(userId, postId, trackChanges: false);

            return Ok(post);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreatePostForUser(Guid userId, [FromBody]
        PostCreationDto post)
        {
            var postToReturn = await _service.PostService.CreatePostForUserAsync
                (userId, post, trackChanges:false);

            return CreatedAtRoute(
                "GetPostForUser",
                new
                    {
                        userId,
                        postId = postToReturn.Id
                    },
                 postToReturn
            );
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeletePostForUser(Guid userId, Guid id)
        {
            await _service.PostService.DeletePostForUserAsync(userId, id,
                trackChanges: false);

            return NoContent();
        }

        [HttpPut("{id:guid}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdatePostForUser(Guid userId, Guid id,
            [FromBody] PostForUpdateDto post)
        {
            await _service.PostService.UpdatePostForUserAsync(userId, id, post,
            userTrackChanges: false, postTrackChanges: true);

            return NoContent();
        }

        [HttpPatch("{id:guid}")]
        public async Task<IActionResult> PartiallyUpdatePostForUser
            (Guid userId, Guid id, [FromBody] JsonPatchDocument
            <PostForUpdateDto> patchDoc)
        {
            if (patchDoc is null)
                return BadRequest("patchDoc object sent from client is null.");

            var result = await _service.PostService.GetPostForPatchAsync(userId, id,
            userTrackChanges: false, postTrackChanges: true);

            patchDoc.ApplyTo(result.postToPatch, ModelState);

            TryValidateModel(result.postToPatch);

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _service.PostService.SaveChangesForPatchAsync(result.postToPatch,
            result.postEntity);

            return NoContent();
        }
    }
}

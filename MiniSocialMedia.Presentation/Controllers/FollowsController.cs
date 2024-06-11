using Microsoft.AspNetCore.Mvc;
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
    [Route("api/users/{userId}/follows")]
    [ApiController]
    public class FollowsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public FollowsController(IServiceManager service) => _service = service;

        [HttpGet]
        public async Task<IActionResult> GetFollowersForUser(Guid userId,
            [FromQuery] FollowParameters followParameters)
        {
            var pagedResult = await _service.FollowService.GetFollowersAsync
                (userId, followParameters, trackChanges: false);

            Response.Headers.Add("X-pagination", JsonSerializer.Serialize(pagedResult.metaData));

            return Ok(pagedResult.follows);
        }

        [HttpGet("{followerId:guid}", Name = "GetFollowerForUser")]
        public async Task<IActionResult> GetFollowerForUser(Guid userId, Guid followerId)
        {
            var follower = await _service.FollowService.GetFollowerAsync(userId, followerId, trackChanges: false);

            return Ok(follower);
        }

        [HttpGet("followees")]
        public async Task<IActionResult> GetFolloweesForUser(Guid userId)
        {
            var followees = await _service.FollowService.GetFolloweesAsync(userId, trackChanges: false);
            return Ok(followees);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateFollowerForUser(Guid userId, [FromBody]
        FollowCreationDto follower)
        {
            var followToReturn = await _service.FollowService
                .CreateFollowerForUserAsync(userId, follower, trackChanges:
           false);

            return CreatedAtRoute(
                "GetFollowerForUser",
                new
                {
                    userId,
                    followerId = followToReturn.Id
                },
                 followToReturn
            );
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteFollowerForUser(Guid userId, Guid id)
        {
            await _service.FollowService.DeleteFollowerForUserAsync(userId, id, trackChanges:
            false);

            return NoContent();
        }
    }
}

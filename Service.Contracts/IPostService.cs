using Entities.Models;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IPostService
    {
        Task<(IEnumerable<PostDto> posts, MetaData metaData)> GetPostsAsync(Guid userId,
            PostParameters postParameters, bool trackChanges);

        Task<PostDto> GetPostAsync(Guid userId, Guid id, bool trackChanges);

        Task<(IEnumerable<PostDto> posts, MetaData metaData)> GetRecentPostsAsync
            (Guid userId, List<Guid> followeeList, PostParameters postParameters,
            bool trackChanges);

        Task<PostDto> CreatePostForUserAsync(Guid userId, PostCreationDto
            postCreation, bool trackChanges);

        Task DeletePostForUserAsync(Guid userId, Guid id, bool trackChanges);

        Task UpdatePostForUserAsync(Guid userId, Guid id,
            PostForUpdateDto postForUpdate, bool userTrackChanges, bool
            postTrackChanges);

        Task<(PostForUpdateDto postToPatch, Post postEntity)>
            GetPostForPatchAsync(Guid userId, Guid id, bool userTrackChanges, bool postTrackChanges);

        Task SaveChangesForPatchAsync(PostForUpdateDto postToPatch, Post
        postEntity);
    }
}

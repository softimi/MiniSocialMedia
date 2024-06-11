using Entities.Models;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IPostRepository
    {
        Task<PagedList<Post>> GetPostsAsync(Guid userId, PostParameters postParameters, bool trackChanges);

        Task<Post> GetPostAsync(Guid userId, Guid id, bool trackChanges);

        Task<PagedList<Post>> GetRecentPostsAsync(Guid userId, List<Guid> followeeList,
            PostParameters postParameters, bool trackChanges);

        void CreatePostForUser(Guid userId, Post post);

        void DeletePost(Post post);
    }
}

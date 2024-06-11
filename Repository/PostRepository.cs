using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    internal sealed class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public void CreatePostForUser(Guid userId, Post post)
        {
            post.UserId = userId;
            Create(post);
        }

        public void DeletePost(Post post) => Delete(post);

        public async Task<Post> GetPostAsync(Guid userId, Guid id, bool trackChanges) =>
        await FindByCondition(p => p.UserId.Equals(userId) && p.Id.Equals(id), trackChanges)
        .SingleOrDefaultAsync();

        public async Task<PagedList<Post>> GetPostsAsync(Guid userId, 
            PostParameters postParameters, bool trackChanges)
        {
            var posts = await FindByCondition(p => p.UserId.Equals(userId), trackChanges)
            .OrderByDescending(p => p.CreatedAt)
            .Skip((postParameters.PageNumber - 1) * postParameters.PageSize)
            .Take(postParameters.PageSize)
            .ToListAsync();

            return PagedList<Post>
                .ToPagedList(posts, postParameters.PageNumber,
                postParameters.PageSize);
        }

        public async Task<PagedList<Post>> GetRecentPostsAsync(Guid userId, List<Guid> followeeList,
            PostParameters postParameters, bool trackChanges)
        {
            var posts = await FindByCondition(p => p.UserId.Equals(userId) || followeeList.Contains(p.UserId)
            , trackChanges)
            .OrderByDescending(p => p.Likes)
            .Skip((postParameters.PageNumber - 1) * postParameters.PageSize)
            .Take(postParameters.PageSize)
            .ToListAsync();

            /*
            var posts = await FindByCondition(p => p.UserId.Equals(userId) || followeeList.Contains(p.UserId)
            && (p.CreatedAt >= postParameters.MinDate && p.CreatedAt 
            <= postParameters.MaxDate), trackChanges)
            .OrderByDescending(p => p.CreatedAt)
            .Skip((postParameters.PageNumber - 1) * postParameters.PageSize)
            .Take(postParameters.PageSize)
            .ToListAsync();
            */


            return PagedList<Post>
                .ToPagedList(posts, postParameters.PageNumber,
                postParameters.PageSize);
        }
    }
}

using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
    internal sealed class FollowRepository : RepositoryBase<Follow>, IFollowRepository
    {
        public FollowRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public async Task<PagedList<Follow>> GetFollowersAsync(Guid userId, 
            FollowParameters followParameters, bool trackChanges)
        {
            var followers = await FindByCondition(f => f.FolloweeId.Equals(userId), trackChanges)
            //.OrderBy(f => f.Id).ToList();
            .Skip((followParameters.PageNumber - 1) * followParameters.PageSize)
            .Take(followParameters.PageSize)
            .ToListAsync();

            return PagedList<Follow>
                .ToPagedList(followers, followParameters.PageNumber,
                followParameters.PageSize);
        }

        public async Task<IEnumerable<Follow>> GetFolloweesAsync(Guid userId,
            bool trackChanges) =>
            await FindByCondition(f => f.FollowerId.Equals(userId), trackChanges)
            .ToListAsync();


        public async Task<Follow> GetFollowerAsync
            (Guid followeeId, Guid followerId, bool trackChanges) =>
        await FindByCondition(f => f.FolloweeId.Equals(followeeId) && 
        f.FollowerId.Equals(followerId), trackChanges)
        .SingleOrDefaultAsync();

        public void CreateFollowerForUser(Guid userId, Follow follower)
        {

            follower.FolloweeId = userId;
            Create(follower);
        }

        public void DeleteFollower(Follow follow) => Delete(follow);
    }
}

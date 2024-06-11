using Entities.Models;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IFollowRepository
    {
        Task<PagedList<Follow>> GetFollowersAsync(Guid userId, 
            FollowParameters followParameters, bool trackChanges);

        Task<IEnumerable<Follow>> GetFolloweesAsync(Guid userId, bool trackChanges);

        Task<Follow> GetFollowerAsync(Guid followeeId, Guid followerId, bool trackChanges);

        void CreateFollowerForUser(Guid userId, Follow follow);

        void DeleteFollower(Follow follow);
    }
}

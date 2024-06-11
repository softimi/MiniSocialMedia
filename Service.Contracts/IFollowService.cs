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
    public interface IFollowService
    {
        Task<(IEnumerable<FollowDto> follows, MetaData metaData)> GetFollowersAsync(Guid userId, 
            FollowParameters followParameters, bool trackChanges);

        Task<FollowDto> GetFollowerAsync(Guid followeeId, Guid FollowerId, bool trackChanges);

        Task<List<Guid>> GetFolloweesAsync(Guid userId, bool trackChanges);

        Task<FollowDto> CreateFollowerForUserAsync(Guid userId, FollowCreationDto
            followCreation, bool trackChanges);

        Task DeleteFollowerForUserAsync(Guid userId, Guid id, bool trackChanges);
    }
}

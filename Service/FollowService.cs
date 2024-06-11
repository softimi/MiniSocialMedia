using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class FollowService : IFollowService
    {
        private readonly IRepositoryManager _repository;

        private readonly ILoggerManager _logger;

        private readonly IMapper _mapper;

        public FollowService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;

            _logger = logger;

            _mapper = mapper;
        }

        public async Task<FollowDto> CreateFollowerForUserAsync
            (Guid userId, FollowCreationDto followCreation, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var followEntity = _mapper.Map<Follow>(followCreation);

            _repository.Follow.CreateFollowerForUser(userId, followEntity);

            await _repository.SaveAsync();

            var followerToReturn = _mapper.Map<FollowDto>(followEntity);

            return followerToReturn;
        }

        public async Task DeleteFollowerForUserAsync(Guid userId, Guid id, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var followDb = await GetFollowerForUserAndCheckIfItExists(userId, id,
                trackChanges);

            _repository.Follow.DeleteFollower(followDb);

            await _repository.SaveAsync();
        }

        public async Task<FollowDto> GetFollowerAsync(Guid followeeId, Guid followerId, bool trackChanges)
        {
            await CheckIfUserExists(followeeId, trackChanges);

            await CheckIfUserExists(followerId, trackChanges);

            var followDb = await _repository.Follow.GetFollowerAsync(followeeId, followerId, trackChanges);

            if (followDb is null)
                throw new FollowerNotFoundException(followerId);

            var follower = _mapper.Map<FollowDto>(followDb);

            return follower;
        }

        public async Task<(IEnumerable<FollowDto> follows, MetaData metaData)> GetFollowersAsync(Guid userId, 
            FollowParameters followParameters, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var followsWithMetaData = 
                await _repository.Follow.GetFollowersAsync(userId, followParameters, trackChanges);

            var followsDto = _mapper.Map<IEnumerable<FollowDto>>(followsWithMetaData);

            return (follows: followsDto, metaData: followsWithMetaData.MetaData);

        }

        public async Task<List<Guid>> GetFolloweesAsync(Guid userId, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var followeesFromDb = await _repository.Follow.GetFolloweesAsync(userId, trackChanges);

            var followeesDto = _mapper.Map<IEnumerable<FollowDto>>(followeesFromDb);

            var followeeIds = followeesDto.Select(f => f.FolloweeId).ToList();

            return followeeIds;
        }


        private async Task CheckIfUserExists(Guid userId, bool trackChanges)
        {
            var user = await _repository.User.GetUserAsync(userId, trackChanges);
            if (user is null)
                throw new UserNotFoundException(userId);
        }

        private async Task<Follow> GetFollowerForUserAndCheckIfItExists
            (Guid userId, Guid id, bool trackChanges)
        {
            var followDb = await _repository.Follow.GetFollowerAsync(userId, id,
                trackChanges);

            if (followDb is null)
                throw new FollowerNotFoundException(id);

            return followDb;
        }
    }
}

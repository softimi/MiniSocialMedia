using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;
using System.ComponentModel.Design;

namespace Service
{
    internal sealed class PostService : IPostService
    {
        private readonly IRepositoryManager _repository;

        private readonly ILoggerManager _logger;

        private readonly IMapper _mapper;

        public PostService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;

            _logger = logger;

            _mapper = mapper;
        }

        public async Task<PostDto> CreatePostForUserAsync(Guid userId, PostCreationDto postCreation, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var postEntity = _mapper.Map<Post>(postCreation);

            _repository.Post.CreatePostForUser(userId, postEntity);

            await _repository.SaveAsync();

            var postToReturn = _mapper.Map<PostDto>(postEntity);

            return postToReturn;
        }

        public async Task DeletePostForUserAsync(Guid userId, Guid id, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var postDb = await GetPostForUserAndCheckIfItExists(userId, id,
                trackChanges);

            _repository.Post.DeletePost(postDb);

            await _repository.SaveAsync();
        }

        public async Task<PostDto> GetPostAsync(Guid userId, Guid id, bool trackChanges)
        {
            await CheckIfUserExists(userId, trackChanges);

            var postDb = await _repository.Post.GetPostAsync(userId, id, trackChanges);

            if (postDb is null)
                throw new PostNotFoundException(id);

            var post = _mapper.Map<PostDto>(postDb);

            return post;
        }

        public async Task<(IEnumerable<PostDto> posts, MetaData metaData)>
            GetRecentPostsAsync (Guid userId, List<Guid> followeeList, 
            PostParameters postParameters, bool trackChanges)
        {
            if (!postParameters.ValidDateRange)
                throw new MaxDateRangeBadRequestException();

            await CheckIfUserExists(userId, trackChanges);

            //await CheckIfUsersExist(followeeList, trackChanges);

            var postsWithMetaData = await _repository.Post.GetRecentPostsAsync
                (userId, followeeList, postParameters, trackChanges);

            var postsDto = _mapper.Map<IEnumerable<PostDto>>(postsWithMetaData);

            return (posts: postsDto, metaData: postsWithMetaData.MetaData);
        }

        public async Task<(PostForUpdateDto postToPatch, Post postEntity)> 
            GetPostForPatchAsync(Guid userId, Guid id, bool userTrackChanges, bool postTrackChanges)
        {
            await CheckIfUserExists(userId, userTrackChanges);

            var postDb = await GetPostForUserAndCheckIfItExists(userId, id,
                postTrackChanges);

            var postToPatch = _mapper.Map<PostForUpdateDto>(postDb);

            return (postToPatch: postToPatch, postEntity: postDb);
        }

        public async Task SaveChangesForPatchAsync(PostForUpdateDto postToPatch, Post postEntity)
        {
            _mapper.Map(postToPatch, postEntity);

            await _repository.SaveAsync();
        }

        public async Task<(IEnumerable<PostDto> posts, MetaData metaData)> GetPostsAsync(Guid userId,
            PostParameters postParameters, bool trackChanges)
        {
            if (!postParameters.ValidDateRange)
                throw new MaxDateRangeBadRequestException();

            await CheckIfUserExists(userId, trackChanges);

            var postsWithMetaData = await _repository.Post.GetPostsAsync(userId, postParameters, trackChanges);

            var postsDto = _mapper.Map<IEnumerable<PostDto>>(postsWithMetaData);

            return (posts: postsDto, metaData: postsWithMetaData.MetaData);
        }

        public async Task UpdatePostForUserAsync(Guid userId, Guid id, 
            PostForUpdateDto postForUpdate, bool userTrackChanges, bool postTrackChanges)
        {
            await CheckIfUserExists(userId, userTrackChanges);

            var postDb = await GetPostForUserAndCheckIfItExists(userId, id,
                postTrackChanges);

            _mapper.Map(postForUpdate, postDb);

            await _repository.SaveAsync();
        }


        private async Task CheckIfUserExists(Guid userId, bool trackChanges)
        {
            var user = await _repository.User.GetUserAsync(userId, trackChanges);
            if (user is null)
                throw new UserNotFoundException(userId);
        }


        /*private async Task CheckIfUsersExist(List<Guid> userIds, bool trackChanges)
        {
            foreach (var userId in userIds)
            {
                var user = await _repository.User.GetUserAsync(userId, trackChanges);
                if (user is null)
                    throw new UserNotFoundException(userId);
            }
        }*/

        private async Task<Post> GetPostForUserAndCheckIfItExists
            (Guid userId, Guid id, bool trackChanges)
        {
            var postDb = await _repository.Post.GetPostAsync(userId, id,
                trackChanges);

            if (postDb is null)
                throw new PostNotFoundException(id);

            return postDb;
        }
    }
}

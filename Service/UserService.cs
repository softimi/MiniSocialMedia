using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class UserService : IUserService
    {
        private readonly IRepositoryManager _repository;

        private readonly ILoggerManager _logger;

        private readonly IMapper _mapper;

        public UserService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;

            _logger = logger;

            _mapper = mapper;
        }

        public async Task<UserDto> CreateUserAsync(UserForCreationDto user)
        {
            var userEntity = _mapper.Map<User>(user);

            _repository.User.CreateUser(userEntity);

            await _repository.SaveAsync();

            var userToReturn = _mapper.Map<UserDto>(userEntity);

            return userToReturn;
        }

        public async Task<(IEnumerable<UserDto> users, string ids)> 
            CreateUserCollectionAsync(IEnumerable<UserForCreationDto> userCollection)
        {
            if (userCollection is null)
                throw new UserCollectionBadRequest();

            var userEntities = _mapper.Map<IEnumerable<User>>(userCollection);

            foreach (var user in userEntities)
            {
                _repository.User.CreateUser(user);
            }

            await _repository.SaveAsync();

            var userCollectionToReturn =
                _mapper.Map<IEnumerable<UserDto>>(userEntities);

            var ids = string.Join(",", userCollectionToReturn.Select(u => u.id));

            return (users: userCollectionToReturn, ids: ids);
        }

        public async Task DeleteUserAsync(Guid userId, bool trackChanges)
        {
            var user = await GetUserAndCheckIfItExists(userId, trackChanges);

            _repository.User.DeleteUser(user);

            await _repository.SaveAsync();
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync(bool trackChanges)
        {
            var users = await _repository.User.GetAllUsersAsync(trackChanges);

            var usersDto = _mapper.Map<IEnumerable<UserDto>>(users);

            return usersDto;
        }

        public async Task<IEnumerable<UserDto>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges)
        {
            if (ids is null)
                throw new IdParametersBadRequestException();

            var userEntities = await _repository.User.GetByIdsAsync(ids, trackChanges);

            if (ids.Count() != userEntities.Count())
                throw new CollectionByIdsBadRequestException();

            var usersToReturn = _mapper.Map<IEnumerable<UserDto>>(userEntities);

            return usersToReturn;
        }

        public async Task<UserDto> GetUserAsync(Guid id, bool trackChanges)
        {
            var user = await GetUserAndCheckIfItExists(id, trackChanges);

            var userDto = _mapper.Map<UserDto>(user);

            return userDto;
        }

        public async Task UpdateUserAsync(Guid userId, UserForUpdateDto userForUpdate, bool trackChanges)
        {
            var user = await GetUserAndCheckIfItExists(userId, trackChanges);

            _mapper.Map(userForUpdate, user);

            await _repository.SaveAsync();
        }


        private async Task<User> GetUserAndCheckIfItExists(Guid id, bool trackChanges)
        {
            var user = await _repository.User.GetUserAsync(id, trackChanges);
            if (user is null)
                throw new UserNotFoundException(id);
            return user;
        }
    }
}

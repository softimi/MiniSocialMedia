using AutoMapper;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;

        private readonly Lazy<IPostService> _postService;

        private readonly Lazy<IFollowService> _followService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, logger, mapper));

            _postService = new Lazy<IPostService>(() => new PostService(repositoryManager, logger, mapper));

            _followService = new Lazy<IFollowService>(() => new FollowService(repositoryManager, logger, mapper));
        }

        public IUserService UserService => _userService.Value;

        public IPostService PostService => _postService.Value;

        public IFollowService FollowService => _followService.Value;
    }
}

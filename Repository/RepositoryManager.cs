using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;

        private readonly Lazy<IUserRepository> _userRepository;

        private readonly Lazy<IPostRepository> _postRepository;

        private readonly Lazy<IFollowRepository> _followRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;

            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));

            _postRepository = new Lazy<IPostRepository>(() => new PostRepository(repositoryContext));

            _followRepository = new Lazy<IFollowRepository>(() => new FollowRepository(repositoryContext));
        }

        public IUserRepository User => _userRepository.Value;

        public IPostRepository Post => _postRepository.Value;

        public IFollowRepository Follow => _followRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}

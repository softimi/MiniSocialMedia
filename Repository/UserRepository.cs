using Contracts;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
    internal sealed class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges) =>
        await FindAll(trackChanges)
        .OrderBy(u => u.Username)
        .ToListAsync();

        public async Task<User> GetUserAsync(Guid userId, bool trackChanges) =>
            await FindByCondition(u => u.Id.Equals(userId), trackChanges)
            .SingleOrDefaultAsync();

        public void CreateUser(User user) => Create(user);

        public async Task<IEnumerable<User>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges) =>
            await FindByCondition(x => ids.Contains(x.Id), trackChanges)
            .ToListAsync();

        public void DeleteUser(User user) => Delete(user);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IUserRepository
    {

        Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);

        Task<User> GetUserAsync(Guid userId, bool trackChanges);

        void CreateUser(User user);

        Task<IEnumerable<User>> GetByIdsAsync(IEnumerable<Guid> ids, bool trackChanges);

        void DeleteUser(User user);
    }
}

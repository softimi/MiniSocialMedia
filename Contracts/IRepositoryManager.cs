﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository User { get; }

        IPostRepository Post { get; }

        IFollowRepository Follow { get; }

        Task SaveAsync();
    }
}

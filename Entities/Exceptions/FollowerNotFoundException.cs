using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class FollowerNotFoundException : NotFoundException
    {
        public FollowerNotFoundException(Guid id)
            : base($"Follower with id: {id} is not following you.")
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class PostNotFoundException : NotFoundException
    {
        public PostNotFoundException(Guid id)
            : base($"Post with id: {id} doesn't exist in the database.")
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    //public record FollowDto(Guid FollowId, Guid FollowerId, Guid FolloweeId);

    public class FollowDto
    {
        public Guid Id { get; set; }

        public Guid FollowerId { get; set; }

        public Guid FolloweeId { get; set; }


        public FollowDto()
        {

        }
    }
}

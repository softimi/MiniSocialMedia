using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Follow
    {
        [Key]
        [Column("FollowId")]
        public Guid Id { get; set; }

        public Guid FollowerId { get; set; }

        public Guid FolloweeId { get; set; }

        public User? Follower { get; set; }
        public User? Followee { get; set; }
    }
}

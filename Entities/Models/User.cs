using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User
    {
        [Column("UserId")]
        public Guid Id { get; set; }

        public string? Username { get; set; }


        public ICollection<Post>? Posts { get; set; }

        public ICollection<Follow>? Followers { get; set; }

        public ICollection<Follow>? Followees { get; set; }
    }
}

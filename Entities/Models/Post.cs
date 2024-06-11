using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Post
    {
        [Column("PostId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Text is a required field.")]
        [MaxLength(140, ErrorMessage = "Maximum length for the text is 140 characters.")]
        public string? Text { get; set; }

        public int Likes { get; set; } = 0;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime ModifiedAt { get; set; } = DateTime.Now;


        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public User? User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record UserForCreationDto
    {
        [Required(ErrorMessage = "Username is a required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the Username is " +
            "20 characters.")]
        public string Username { get; set; }
    }

    // To create post during user creation
    /*public record UserForCreationDto(string username,
        IEnumerable<PostCreationDto> Posts);*/
}

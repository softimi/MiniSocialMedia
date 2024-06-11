﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public abstract record PostForManipulationDto
    {
        [Required(ErrorMessage = "Text is a required field.")]
        [MaxLength(140, ErrorMessage = "Maximum length for the Text is " +
            "140 characters.")]
        public string Text { get; set; }

        //public Guid UserId { get; set; }

        [JsonIgnore]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [JsonIgnore]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}

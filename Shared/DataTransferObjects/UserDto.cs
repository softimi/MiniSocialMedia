﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DataTransferObjects
{
    public record UserDto
    {
        public Guid id { get; set; }
        public string? username { get; set; }
    }
}

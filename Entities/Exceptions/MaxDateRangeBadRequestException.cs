using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public sealed class MaxDateRangeBadRequestException : BadRequestException
    {
        public MaxDateRangeBadRequestException() 
            : base("Max date can't be less than min date.") { }
    }
}

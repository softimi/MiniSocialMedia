using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.RequestFeatures
{
    public class PostParameters : RequestParameters
    {

        public DateTime MinDate { get; set; } = DateTime.Today.Subtract(new TimeSpan(168, 0, 0));
        public DateTime MaxDate { get; set; } = DateTime.Today;
        public bool ValidDateRange => MaxDate > MinDate;
    }
}

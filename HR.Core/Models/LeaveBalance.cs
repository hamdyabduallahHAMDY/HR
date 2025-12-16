using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class LeaveBalance : Common
    {
        public int TotalDays { get; set; }
       public int UsedDays { get; set; }
       public int RemainingDays => TotalDays - UsedDays;
    }
}

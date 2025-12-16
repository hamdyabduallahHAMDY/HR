using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public  class PayRollDeduction : Common
    {
        public Employee Employee{ get; set; }
        public int EmployerId { get; set; } 
        public DateTime Month { get; set;}
        public LeaveRequest LeaveRequest{ get; set; }
        public int LeaverequestId { get; set; }
        public decimal Amount { get; set; }

    }
}

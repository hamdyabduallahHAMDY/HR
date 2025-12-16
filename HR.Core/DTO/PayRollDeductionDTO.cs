using HR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.DTO
{
    public class PayRollDeductionDTO
    {
        public int EmployerId { get; set; }
        public DateTime Month { get; set; }
        public int LeaverequestId { get; set; }
        public decimal Amount { get; set; }
    }
}

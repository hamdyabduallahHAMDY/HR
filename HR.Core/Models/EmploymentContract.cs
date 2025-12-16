using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class EmploymentContract : Common
    {
        public ContractType contractType {  get; set; }
        public LeaveBalance balance { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }
        public decimal BasicSalary { get; set; }
        public bool isRenewable { get; set; }
        public Allaonce Allaonce { get; set; }

    }
}

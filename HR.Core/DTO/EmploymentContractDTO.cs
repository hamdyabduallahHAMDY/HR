using HR.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.DTO
{
    public  class EmploymentContractDTO
    {
        public string internalId { get; set; }
        public ContractType contractType { get; set; }
        public LeaveBalance balance { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }
        public decimal BasicSalary { get; set; }
        public bool isRenewable { get; set; }
        public AllaonceDTO Allaonce { get; set; }

    }
}

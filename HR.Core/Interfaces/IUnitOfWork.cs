using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using HR.Core.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HR.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
     ICmd<User> Users { get; }
     ICmd<Department> Departments { get; }
     ICmd<Employee> Employees { get; }
     ICmd<EmploymentContract> EmploymentsContracts { get; }
     ICmd<GroupRol> GroupRols { get; }
     ICmd<Job> Job { get; }
     ICmd<LeaveBalance> LeaveBalances { get; }
     ICmd<LeaveRequest> LeaveRequests { get; }
     ICmd<PayRollDeduction> PayRollDeductions { get; }

        
        
        
        
        
        
        Task<int> Complete();

    }
}

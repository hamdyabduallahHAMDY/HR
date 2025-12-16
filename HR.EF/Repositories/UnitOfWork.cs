using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HR.Core.Interfaces;
using HR.Core.Models;
using HR.EF.DataAccess;

using static System.Net.Mime.MediaTypeNames;

namespace HR.EF.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICmd<User> Users { get; }
        public ICmd<Department> Departments { get; }
        public ICmd<Employee> Employees { get; }
        public ICmd<EmploymentContract> EmploymentsContracts { get; }
        public ICmd<GroupRol> GroupRols { get; }
        public ICmd<Job> Job { get; }
        public ICmd<LeaveBalance> LeaveBalances { get; }
        public ICmd<LeaveRequest> LeaveRequests { get; }
        public ICmd<PayRollDeduction> PayRollDeductions { get; }
        

                public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
         
          
        }
        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }
        /*  public int Complete()
          {
              return _context.SaveChanges();
          }  
         */

        public void Dispose()
        {
            _context.Dispose();
        }
    

}
}

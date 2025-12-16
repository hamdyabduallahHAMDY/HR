using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Core.Models
{
    public class Job : Common
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Department Department{ get; set; }
        public int DepartmentId { get; set; }

    }
}

using System;
using System.Collections.Generic;

namespace BandR.Models
{
    public class Department
    {
        public virtual int DepartmentId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }  
    }
}

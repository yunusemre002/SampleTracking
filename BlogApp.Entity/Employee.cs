using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagement.Entity
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Sample> Samples { get; set; }
    }
}

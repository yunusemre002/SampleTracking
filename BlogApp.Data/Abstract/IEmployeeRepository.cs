using ProjectManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagement.Data.Abstract
{
    public interface IEmployeeRepository
    {
        Employee GetById(int emloyeeId);
        IQueryable<Employee> GetAll();
        void AddEmployee(Employee entity);
        void UpdateEmployee(Employee entity);
        void DeleteEmployee(int employeeId);
        EmployeeStatics GetEmployeeStatics(int employeeId);
        IEnumerable<GanttStatics> GetGanttForEmp(int employeeId);


    }
}

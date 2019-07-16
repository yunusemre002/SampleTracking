using ProjectManagement.Data.Abstract;
using ProjectManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagement.Data.Concrete.EFCore
{
    public class EfEmployeeRepository : IEmployeeRepository
    {

        private PMContext context;

        public EfEmployeeRepository(PMContext _context)
        {
            context = _context;
        }

        public void AddEmployee(Employee entity)
        {
            context.Employees.Add(entity);
            context.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = context.Employees.FirstOrDefault(p => p.EmployeeId == employeeId);

            if(employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }

        public IQueryable<Employee> GetAll()
        {
            return context.Employees;
        }

        public Employee GetById(int emloyeeId)
        {
            return context.Employees.FirstOrDefault(p=>p.EmployeeId == emloyeeId);
        }

        public void UpdateEmployee(Employee entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}

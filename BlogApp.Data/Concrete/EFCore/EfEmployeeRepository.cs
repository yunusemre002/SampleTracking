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

        public EmployeeStatics GetEmployeeStatics(int employeeId)
        {
            EmployeeStatics employeeStatics = new EmployeeStatics();
            employeeStatics.EmployeeName = GetById(employeeId).Name;
            employeeStatics.ClosedIssues = context.Samples.Count(i=>i.EmployeeId==employeeId && i.SampleState==Entity.Enums.State.Tamamlandı);
            employeeStatics.OpenIssues = context.Samples.Count(i=>i.EmployeeId==employeeId && i.SampleState == Entity.Enums.State.Yeni);
            return employeeStatics;
        }

        public Employee GetById(int emloyeeId)
        {
            return context.Employees.FirstOrDefault(p=>p.EmployeeId == emloyeeId);
        }

        public void UpdateEmployee(Employee entity)
        {
            context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public IEnumerable<GanttStatics> GetGanttForEmp(int employeeId)
        {




            List<GanttStatics> gs = new List<GanttStatics>();

            var sampleList=context.Samples.Where(q => q.EmployeeId == employeeId).ToList();

            foreach (var item in sampleList)
            {
                GanttStatics g1 = new GanttStatics();
                g1.Resource = item.Customer;
                g1.TaskId = item.SampleId.ToString();
                g1.TaskName = item.RequestNo;            
                g1.StartDate = item.RequestDate.Year +","+item.RequestDate.Month+","+item.RequestDate.Day;
                g1.EndDate = item.Termin.Year + "," + item.Termin.Month + "," + item.Termin.Day;
                g1.Duration = null;
                g1.Percent = 100;
                g1.Dependencies = null;
                
                gs.Add(g1);
            }

            return gs;
            
        }
    }
}

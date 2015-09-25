using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using BandR.Models;
using BandR.Data;

namespace BandR.Data
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        private HRContext context;

        public EmployeeRepository(HRContext context)
        {
            this.context = context;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return context.Employees.Include("Department").ToList();
        }

        public IEnumerable<Department> GetDepartments()
        {
            return context.Departments.ToList();
        }


        public Employee GetEmployeeById(int EmployeeId)
        {
            return context.Employees.Find(EmployeeId);
        }

        public void InsertEmployee(Employee Employee)
        {
            context.Employees.Add(Employee);
        }

        public void DeleteEmployee(int EmployeeId)
        {
            Employee Employee = context.Employees.Find(EmployeeId);
            context.Employees.Remove(Employee);
        }

        public void UpdateEmployee(Employee Employee)
        {
            //context.Entry(Employee).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

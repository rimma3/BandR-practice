using BandR.Models;
using System;
using System.Collections.Generic;


namespace BandR.Data
{
    public interface IEmployeeRepository : IDisposable
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int employeeId);
        void InsertEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
        void UpdateEmployee(Employee employee);
        IEnumerable<Department> GetDepartments();
        void Save();
    }
}
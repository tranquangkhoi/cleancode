using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace PayrollApp.Logic
{
    class EmployeeLogic
    {
        private EmployeeModel model = new EmployeeModel();
        public List<Employee> GetEmployees(string path)
        {
            var employees = new List<Employee>();
            var employeesCsv = model.GetEmployees(path);
            if (employeesCsv == null)
            {
                return employees;
            }
            foreach (var employee in employeesCsv)
            {
                employees.Add(new Employee() {
                    Name = employee.name,
                    Dob = employee.dob,
                    Role = employee.role,
                    StartDate = employee.startdate,
                    Salary = employee.salary
                });
            }
            return employees;
        }
    }
}

using CsvHelper;
using PayrollApp.DataAccess;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;

namespace PayrollApp.Logic
{
    class EmployeeModel
    {
        public List<EmployeeCsv> GetEmployees(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var employees = csv.GetRecords<EmployeeCsv>().ToList();
                return employees;
            }
        }
    }
}

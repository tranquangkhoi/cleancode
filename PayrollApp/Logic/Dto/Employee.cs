
using System;

namespace PayrollApp.Logic
{
    class Employee
    {
        private string _Salary;

        public string Name { get; set; }
        public string Dob { get; set; }
        public string Role { get; set; }
        public string StartDate { get; set; }
        public string Salary {
            get
            {
                DateTime now = DateTime.Today;
                DateTime startDate = DateTime.ParseExact(StartDate, "yyyyMMdd", null);
                int year = now.Year - startDate.Year;
                double salary;
                Double.TryParse(_Salary, out salary);
                for (int i = 0; i < year; i++)
                {
                    salary += 0.06 * salary;
                }
                return salary.ToString();
            }
            set { _Salary = value; }
        }
        public string Age
        {
            get
            {
                DateTime now = DateTime.Today;
                DateTime birthday = DateTime.ParseExact(Dob, "yyyyMMdd", null);
                int age = now.Year - birthday.Year;
                if (now < birthday.AddYears(age)) age--;
                return age.ToString();
            }
        }
        public string YearsOfExperience {
            get
            {
                DateTime now = DateTime.Today;
                DateTime startDate = DateTime.ParseExact(StartDate, "yyyyMMdd", null);
                int year = now.Year - startDate.Year;
                int month = now.Month - startDate.Month;
                if (now.Month < startDate.Month)
                {
                    year--;
                    month += 12;
                }
                return $"{year} Nam, {month} thang";
            }
        }
    }
}

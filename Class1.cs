using System;
using System.Collections.Generic;
using System.Text;

namespace Json2
{
    class Information
    {
        public string ApplicantID { get; set; }
       

        public List<Employee> employees { get; set; }
    }

    public class Employee
    {
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string School { get; set; }
        public string Degree { get; set; }
        public double GPA { get; set; }

        public string YourSkill { get; set; }
        public string Languages { get; set; }

    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.ConcreateEmployee
{
    class seasonalInterns : IFactory
    {

        public string empName { get; set; }
        public string teamName { get; set; }

        public string managerName { get; set; }

        public string salary { get; set; }

        public string organizationName { get; set; }

        public string employeeCategary { get; set; }

        public string empRole { get; set; }

        internal seasonalInterns()
        {
            
        }


        public void addEmployee(string empName)
        {
            this.empName = empName;
        }

        public IFactory getEmployee()
        {
            this.salary = "1000$";
            this.organizationName = "Cerner helathcare";
            this.employeeCategary = "Intern";
            this.teamName = "Dev Accademy";
            this.managerName = "Kaushal Tiwari";
            this.empRole = "Seasonal Intern";
            return this;
        }
    }
}

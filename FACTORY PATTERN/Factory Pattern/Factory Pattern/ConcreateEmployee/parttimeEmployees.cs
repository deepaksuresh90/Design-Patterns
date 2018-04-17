using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.ConcreateEmployee
{
    class parttimeEmployees : IFactory
    {

        public string empName { get; set; }
        public string teamName { get; set; }

        public string managerName { get; set; }

        public string salary { get; set; }

        public string organizationName { get; set; }

        public string employeeCategary { get; set; }

        public string empRole { get; set; }

        internal parttimeEmployees()
        {
        }

        public void addEmployee(string empName)
        {
            this.empName = empName;
        }

        public IFactory getEmployee()
        {
            this.salary = "2500$";
            this.organizationName = "Jenkins";
            this.employeeCategary = "Consualtant";
            this.teamName = "Analytic data";
            this.managerName = "Ram Shetty";
            this.empRole = "Consultant Engineer";
            return this;
        }

    }
}

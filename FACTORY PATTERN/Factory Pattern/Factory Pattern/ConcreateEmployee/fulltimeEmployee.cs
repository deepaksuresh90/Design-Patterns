using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    class fulltimeEmployee : IFactory
    {

        public string empName { get; set; }
        public string teamName { get; set; }

        public string managerName { get; set; }

        public string salary { get; set; }

        public string organizationName { get; set; }

        public string employeeCategary { get; set; } = "fulltime Employee";

        public string empRole { get; set; }


        public void addEmployee(string empName)
        {
            this.empName = empName;
        }

        public IFactory getEmployee()
        {
            return this;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.ConcreateCreator
{
    public class creatNoEmployee : Creator.abstractEmployee
    {

        public override IFactory createEmployee(EmployeeType type)
        {
            return new noEmployee();
        }
    }

    class noEmployee : IFactory
    {
        public string empName { get; set; }
        public string teamName { get; set; }

        public string managerName { get; set; }

        public string salary { get; set; }

        public string organizationName { get; set; }

        public string employeeCategary { get; set; }

        public string empRole { get; set; }

        public noEmployee()
        {
            
        }



        public void addEmployee(string empName)
        {
            this.empName = "unKnown";
        }

        public IFactory getEmployee()
        {
            this.empName = "unKnown";
            this.salary = "0$";
            this.organizationName = "NIL";
            this.employeeCategary = "NA";
            this.teamName = "NA";
            this.managerName = "Unknown";
            this.empRole = "unknown";
            return this;
        }


    }
}


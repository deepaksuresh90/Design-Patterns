using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    /// <summary>
    /// Factoy defines the methods to create object
    /// </summary>
    public interface IFactory
    {
        string empName { get; set; }
        string teamName { get; set; }

        string managerName { get; set; }

        string salary { get; set; }

        string organizationName { get; set; }

        string employeeCategary { get; set; }

        string empRole { get; set; }

        void addEmployee(string empName);

        IFactory getEmployee();
    }
}

using Factory_Pattern.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.ConcreateCreator
{
    public class CreateEmployee : Creator.abstractEmployee
    {
       public override IFactory createEmployee(EmployeeType type)
        {
            new employeeBuild(type);
            IFactory Employee= employeeBuild.Employee;
            return Employee;
        }
    }
}

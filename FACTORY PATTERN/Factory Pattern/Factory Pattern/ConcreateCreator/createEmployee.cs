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
            IFactory Employee=null;
            switch (type)
            {
                case EmployeeType.FULLTIMEEMPLOYEE:
                    Employee = new fulltimeEmployee();

                    break;
                case EmployeeType.PARTTIMEEMPLOYEE:
                    Employee  = new ConcreateEmployee.parttimeEmployees();
                    break;

                case EmployeeType.INTERNS:
                    Employee = new ConcreateEmployee.seasonalInterns();
                    break;
            }
            return Employee;
        }
    }
}

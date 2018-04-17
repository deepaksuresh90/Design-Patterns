using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Factory_Pattern.Creator.abstractEmployee;

namespace Factory_Pattern
{
    internal class employeeBuild
    {

       internal static IFactory Employee { get; private set; }

        internal employeeBuild(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.FULLTIMEEMPLOYEE:
                    Employee = new fulltimeEmployee();

                    break;
                case EmployeeType.PARTTIMEEMPLOYEE:
                    Employee = new ConcreateEmployee.parttimeEmployees();
                    break;

                case EmployeeType.INTERNS:
                    Employee = new ConcreateEmployee.seasonalInterns();
                    break;
            }
        }
}
}

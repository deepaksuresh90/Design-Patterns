using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Creator
{
   public abstract class  abstractEmployee
    {
        public abstract IFactory createEmployee(EmployeeType type);

        public enum EmployeeType
        {
            FULLTIMEEMPLOYEE,
            PARTTIMEEMPLOYEE,
            INTERNS
        }

    }
}

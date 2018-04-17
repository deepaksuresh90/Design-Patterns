using Factory_Pattern;
using Factory_Pattern.Creator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Factory_Pattern.Creator.abstractEmployee;

namespace TestBuild
{
    class Program
    {
        static void Main(string[] args)
        {

            IFactory employee = null;
            abstractEmployee creator = null;

            // using  concreate creator :CreateEmployee

            creator= new Factory_Pattern.ConcreateCreator.CreateEmployee();
            employee= creator.createEmployee(EmployeeType.FULLTIMEEMPLOYEE);
            employee.addEmployee("Deepak");
            employee =setEmployeeDetails(employee);
            displayEmployeeDetails(employee);

            creator = new Factory_Pattern.ConcreateCreator.CreateEmployee();
            employee = creator.createEmployee(EmployeeType.PARTTIMEEMPLOYEE);
            employee.addEmployee("Janko");
            employee = setEmployeeDetails(employee);
            displayEmployeeDetails(employee);

            // using concreate creator :CreateNoEmployee

            creator = new Factory_Pattern.ConcreateCreator.creatNoEmployee();
            employee = creator.createEmployee(EmployeeType.FULLTIMEEMPLOYEE);
            employee.addEmployee("Kiran");
            employee = setEmployeeDetails(employee);
            displayEmployeeDetails(employee);

        }

        private static IFactory setEmployeeDetails( IFactory employee)
        {
            //employee.empName = "Deepak S";
            employee.empRole = "Sr Software Engineer";
            employee.managerName = "Shetty";
            employee.organizationName = "NFC corporation";
            employee.teamName = "cloud apps";
            employee.salary = "$1000";

           return employee.getEmployee();
        }


        private static void displayEmployeeDetails(IFactory employee)
        {
            Console.WriteLine("Employee Name : {0} \n Employee Role : {1} \n Manager : {2} \n Organization : {3}  \n teamname : {4} \n salary : {5} \n Type : {6} ",
                employee.empName, employee.empRole, employee.managerName, employee.organizationName, employee.teamName, employee.salary,employee.employeeCategary);
            Console.ReadLine();
        }
    }
}

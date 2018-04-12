using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Manager manager = new Manager();
           
            Employee employee = new Employee();
            employee.calculateSalary(sal: 2);
            employee.subRole();

            //example of Named Parameter
            manager.Routine(employeeId: 2);
            manager.Routine( 2);
            manager.subRole();
            manager.calculateSalary(sal: 1);
            Console.ReadLine();
        }
    }
}

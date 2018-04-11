using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee : Person
    {

        public double Salary { get; set; }
       
      //  Employee employee = new Employee() { Name = ""};
        
        public override void Routine()
        {
            Console.WriteLine("I am very Lazy employee");
        }
       public virtual void subRole()
        {

            Console.WriteLine("I am an employee and my sub role is to eats french fries");
        }

        public decimal calculateSalary(int sal)
        {

            return 2;
        }


    }
}

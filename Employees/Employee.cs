using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Employee : Person , IAmex, IChase
    {

        public double Salary { get; set; }
        public string ccNum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int cvv { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        

        //  Employee employee = new Employee() { Name = ""};

        //public override void Routine(int employeeId, string optionalEmail = "")
        //{
        //    Console.WriteLine( $" employee with employee Id {employeeId} Does not need to do much");
        //}

        public override void Routine(int employeeId, string optionalEmail = "default")
        {
            base.Routine(employeeId, optionalEmail);
        }
        public virtual void subRole()
        {

            Console.WriteLine("I am an employee and my sub role is to eats french fries");
        }

        public decimal calculateSalary(int sal)
        {

            return 2;
        }

        public string offer(int CreditScore, decimal salary)
        {
            throw new NotImplementedException();
        }

        public decimal availableBalance(decimal expenditure, decimal limit)
        {
            throw new NotImplementedException();
        }
    }
}

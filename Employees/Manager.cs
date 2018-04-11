using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager: Employee
    {
        public List<string> Perks { get; set; }

        //public new void subRole()
        //{

        //    Console.WriteLine("This is Manager sub role");
        //}

   public override void subRole()
        {

            Console.WriteLine("This is Manager sub role");
        }
    }
}

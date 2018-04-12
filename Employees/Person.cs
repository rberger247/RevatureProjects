using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Person
    {
        private string name;
        public string _name { get { return name; } set { name = value; } }
        protected string SSN;
        public DateTime DOB { get; set; }
        protected decimal money;
        public decimal  _money {
       
            set { money = value; } }
        //public Person(string name)
        //{

        //    this.name = name;
        //}


        //     public abstract void Routine(int employeeId, string optionalEmail = "default");

        public virtual void Routine(int employeeId, string optionalEmail = "default") { }


    }
}

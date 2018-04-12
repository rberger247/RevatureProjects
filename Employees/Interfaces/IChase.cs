using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    interface IChase : ICredit
    {

        string offer(int creditScore, decimal Salary);
    }
}

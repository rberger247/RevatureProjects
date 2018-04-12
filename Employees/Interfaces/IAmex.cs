using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    interface IAmex : ICredit
    {
        string offer(int CreditScore, decimal salary);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    interface ICredit
    {
        string ccNum { get; set; }
        int cvv { get; set; }
        decimal availableBalance(decimal expenditure, decimal limit);
  
    }
}

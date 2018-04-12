using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Credit : IAmex, IChase
    {
        public string ccNum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int cvv { get ; set; }
        string IChase.offer(int creditScore, decimal Salary)
        {
            if (Salary > 2000 && creditScore > 250)
            {
                return "18% ";
            }
            else if (Salary > 400)
            {

                return "12%";
            }
            else return "";

        }
        public decimal availableBalance(decimal expenditure, decimal limit)
        {
          decimal AvailableBalance = limit - expenditure;
            return AvailableBalance;
        }

         string IAmex.offer(int CreditScore, decimal Salary)
        {
            if (Salary > 2000 && CreditScore > 250)
            {
                return "20% interest Rate";
            }
            else if (Salary > 400)
            {

                return "15% interest rate";
            }
            else return "Not Eligible at this point";
        }
    }
}

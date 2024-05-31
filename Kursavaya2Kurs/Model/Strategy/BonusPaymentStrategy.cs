using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursavaya2Kurs.Model
{
    public class BonusPaymentStrategy : IPaymentStrategy
    {
        public bool Pay(Customer customer, decimal totalAmount)
        {
            if (customer.BonusPoints >= totalAmount)
            {
                customer.BonusPoints -= totalAmount;
                return true;
            }
            return false;
        }
    }

}

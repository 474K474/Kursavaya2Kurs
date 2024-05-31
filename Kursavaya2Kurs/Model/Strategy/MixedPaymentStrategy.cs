using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursavaya2Kurs.Model
{
    public class MixedPaymentStrategy : IPaymentStrategy
    {
        public bool Pay(Customer customer, decimal totalAmount)
        {
            decimal halfAmount = totalAmount / 2;
            if (customer.Cash >= halfAmount && customer.BonusPoints >= halfAmount)
            {
                customer.Cash -= halfAmount;
                customer.BonusPoints -= halfAmount;
                return true;
            }
            return false;
        }
    }

}

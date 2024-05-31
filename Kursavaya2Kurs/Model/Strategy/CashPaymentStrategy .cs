using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursavaya2Kurs.Model
{

    public class CashPaymentStrategy : IPaymentStrategy
    {
        public bool Pay(Customer customer, decimal totalAmount)
        {
            if (customer.Cash >= totalAmount)
            {
                customer.Cash -= totalAmount;
                customer.BonusPoints += totalAmount * 0.1m; // Добавляем 10% к бонусам
                return true;
            }
            return false;
        }
    }

}

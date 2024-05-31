using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursavaya2Kurs.Model
{
    public class Store
    {
        public bool CheckOut(Customer customer, decimal cashPayment, decimal bonusPayment)
        {
            decimal total = customer.GetTotalCartPrice();

            if (cashPayment + bonusPayment >= total)
            {
                customer.Cash -= cashPayment;
                customer.BonusPoints -= bonusPayment;
                if (cashPayment > 0)
                {
                    customer.BonusPoints += total * 0.10m; // 10% бонусов от стоимости покупок
                }
                customer.ClearCart();
                return true;
            }
            return false;
        }
    }


}

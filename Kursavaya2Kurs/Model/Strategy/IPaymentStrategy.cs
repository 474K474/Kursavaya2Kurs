using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursavaya2Kurs.Model
{

    public interface IPaymentStrategy
    {
        bool Pay(Customer customer, decimal totalAmount);
    }
}

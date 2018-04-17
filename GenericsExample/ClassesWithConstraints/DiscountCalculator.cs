using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    //Product is a parent class of multiple, other derrived classes
    public class DiscountCalculator<TProduct> where TProduct : Product
    {

        public float CalculateDiscount (TProduct productin)
        {
            return productin.Price - (productin.Price * 0.2F);
        }

    }
}

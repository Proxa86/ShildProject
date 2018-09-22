using System;

namespace TypeData_literals_variables_page_67
{
    public class UseDecimal
    {
        public void Page_73()
        {
            decimal price = 19.95m;
            decimal discount = 0.15m;
            decimal discountedPrice = price - (price * discount);
            Console.WriteLine("Cost with discount: $"+ discountedPrice);
        } 
    }
}
using System;

namespace TypeData_literals_variables_page_67
{
    public class FutVal
    {
        public void Page_74()
        {
            decimal amount = 1000.0m;
            decimal rate_of_return = 0.07m;
            byte years = 10;

            Console.WriteLine("First investments: $" + amount);
            Console.WriteLine("Profit: $"+rate_of_return);
            Console.WriteLine("Duaring "+years+" years;");

            for (byte i = 0; i < years; i++)
            {
                amount += (amount * rate_of_return);
            }

            Console.WriteLine("The future cost: "+amount);
        }
    }
}
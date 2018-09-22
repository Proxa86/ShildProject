using System;

namespace TypeData_literals_variables_page_67
{
    public class DisplayOptions
    {
        public void Page_78()
        {
            Console.WriteLine("Number\tSquare\tCube");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
            }

            Console.WriteLine("Div 10/3 = {0:#.##}", 10/3.0);
            Console.WriteLine("{0:###,###.##}", 123456.78);

            decimal balance = 123456.09m;
            Console.WriteLine("Current balance: {0:C}", balance);
        }
    }
}
using System;

namespace TypeData_literals_variables_page_67
{
    public class CastExpt
    {
        public void Page_95()
        {
            for (double n = 1.0; n < 10.0; n++)
            {
                Console.WriteLine("Sqrt whith {0} = {1}", n, Math.Sqrt(n));
                Console.WriteLine("Whole path number {0} = {1}", Math.Sqrt(n), (int) Math.Sqrt(n));
                Console.WriteLine("Fractional path number {0} = {1}",Math.Sqrt(n), Math.Sqrt(n)-(int) Math.Sqrt(n));
                Console.WriteLine();
            }
            
        }
    }
}
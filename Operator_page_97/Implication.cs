using System;

namespace Operator_page_97
{
    public class Implication
    {
        public void Page_103()
        {
            bool p = false, q = false;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (i == 0) p = true;
                    if (i == 1) p = false;
                    if (j == 0) q = true;
                    if (j == 1) q = false;

                    Console.WriteLine(" p = "+ p + ", q = "+ q);
                    if(!p | q) Console.WriteLine("Result "+ p + " and "+ q+ " = " + true);
                    Console.WriteLine();
                }
            }
        }
    }
}
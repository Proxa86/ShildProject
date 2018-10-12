using System;

namespace Operator_page_97
{
    public class NoZeroDiv2
    {
        public void Page_119()
        {
            for (int i = -5; i < 6; i++)
            {
                if((i != 0)? ((i%2) == 0): false)
                    Console.WriteLine("100 / "+ i + " equals "+100/i);
            }
        }
    }
}
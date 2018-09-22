using System;
using System.Runtime.CompilerServices;

namespace Operator_page_97
{
    public class PrePostDemo
    {
        public void Page_100()
        {
            int x = 1, y = 0;
            for (int i = 0; i < 10; i++)
            {
                y = y + x++;
                Console.Write(y + " ");
            }

            x = 1;
            y = 0;
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                y = y + ++x;
                Console.Write(y + " ");
            }

        }
    }
}
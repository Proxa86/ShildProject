using System;

namespace Operator_page_97
{
    public class NotDemo
    {
        public void Page_114()
        {
            sbyte sb = -34;

            for (int i = 128; i > 0; i /= 2)
            {
                Console.Write((i & sb) == 0 ? "0 " : "1 ");
               }
            Console.WriteLine();
            sb = (sbyte) ~sb;
            for (int i = 128; i > 0; i /= 2)
            {
                Console.Write((i & sb )==0 ? "0 ": "1 ");
            }
        }
    }
}
using System;

namespace Operator_page_97
{
    public class MakeEven
    {
        public void Page_109()
        {
            for (ushort i = 1; i <= 10; i++)
            {
                ushort num = i;

                Console.WriteLine("num = " + num);
                num = (ushort) (num & 0xFFFE);
                Console.WriteLine("Meaning num after reset junior discharge equals: "+ num);
            }
        }
    }
}
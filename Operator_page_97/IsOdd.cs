using System;

namespace Operator_page_97
{
    public class IsOdd
    {
        public void Page_110()
        {
            ushort num = 10;
            
            if((num & 1) == 1) Console.WriteLine("false");

            num = 11;
            if((num & 1) == 1)
                Console.WriteLine("true -> not even number");
        }
    }
}
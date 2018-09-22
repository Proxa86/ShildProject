using System;

namespace Operator_page_97
{
    public class ShowBits
    {
        public void Page_110()
        {
            byte val = 123;
            for (int t = 128; t > 0; t /= 2)
            {
                if((val & t) != 0) Console.Write("1 ");
                else Console.Write("0 ");
            }
        }
    }
}
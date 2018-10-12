using System;

namespace Operator_page_97
{
    public class MakeOdd
    {
        public void Page_111()
        {
            ushort num;
            for (ushort i = 0; i <= 10; i++)
            {
                num = i;
                Console.WriteLine("num: "+num);
                num = (ushort)(num | 1);
                Console.WriteLine("_num: "+ num);
            }
        }
    }
}
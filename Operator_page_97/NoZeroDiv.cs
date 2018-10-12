using System;

namespace Operator_page_97
{
    public class NoZeroDiv
    {
        public void Page_118()
        {
            for (int i = -5; i < 6; i++)
            {
                int result = i != 0 ? 100 / i : 0;
                if(result != 0)
                    Console.WriteLine("100 / "+ i + " result "+ result);
            }
        }
    }
}
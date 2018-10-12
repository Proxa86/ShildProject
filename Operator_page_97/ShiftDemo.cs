using System;

namespace Operator_page_97
{
    public class ShiftDemo
    {
        public void Page_115()
        {
            int val = 1;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 128; j > 0; j /= 2)
                {
                   // Console.Write((val & j) == 0 ? "0 ": "1 ");
                }

                //Console.WriteLine();
                val <<= 1;
                
            }

            Console.WriteLine();
            val = 128;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 128; j > 0; j /= 2)
                {
                    //Console.Write((val & j) == 0 ? "0 ": "1 ");
                }

                //Console.WriteLine();
                val >>= 1; 
                
            }

            val = 16;
            for (int j = 128; j > 0; j /= 2)
            {
                Console.Write((val & j) == 0 ? "0 ": "1 ");
            }

            Console.WriteLine();
            val <<= 1;
            Console.Write( val + " ");
            val = 128;
            val >>= 1;
            Console.Write( val + " ");
        }
    }
}
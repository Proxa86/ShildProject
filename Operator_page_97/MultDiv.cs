using System;
using System.Data.SqlClient;

namespace Operator_page_97
{
    public class MultDiv
    {
        public void Page_116()
        {
            int n = 10;

            Console.WriteLine("n = "+10);

            Console.WriteLine("\"*\" on 2:" +(n << 1)); //20
            Console.WriteLine("\"*\" on 4:" +(n << 2)); //40
            Console.WriteLine("\"\\\" on 2:" +(n >> 1)); //50
            Console.WriteLine("\"\\\" on 4:" +(n >> 4)); //0
            Console.WriteLine("\"*\" on 30:" +(n << 30));
        }
    }
}
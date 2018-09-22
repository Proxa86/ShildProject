using System;

namespace TypeData_literals_variables_page_67
{
    public class Use_byte
    {
        public void Page_70()
        {
            byte x;
            int sum = 0;

            for (x = 1; x <= 100; x++)
            {
                sum = sum + x;
            }

            Console.WriteLine("Sum number one to 100 equals " + sum);

        }
    }
}
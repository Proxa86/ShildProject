using System;

namespace Exception_page_403
{
    public class CheckedDemo
    {
        public void Page_429()
        {
            byte a, b, result;

            a = b = 127;

            try
            {
                Console.WriteLine("Result don't check.");
                result = unchecked ((byte)(a * b)); //Overflow. Result incorrect.
                Console.WriteLine(result);
                Console.WriteLine("Result is check. As a result exception.");
                result = checked((byte) (a * b));
                Console.WriteLine(result);

            }
            catch (OverflowException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
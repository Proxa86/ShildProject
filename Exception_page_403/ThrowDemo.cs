using System;
using System.IO;

namespace Exception_page_403
{
    public class ThrowDemo
    {
        public void Page_414()
        {
            try
            {
                Console.WriteLine("Before exception.");
                throw new DivideByZeroException();

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception catch.");
            }

            Console.WriteLine("End exception.");
        }
    }
}
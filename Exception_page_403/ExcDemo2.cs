using System;

namespace Exception_page_403
{
    public class ExcDemo2
    {
        public void Page_407()
        {
            try
            {
                ExcTest.GenException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("index out border array.");
            }

            Console.WriteLine("End block exception.");
        }
    }
}
using System;

namespace Exception_page_403
{
    public class ExcTypeMismatch
    {
        public void Page_409()
        {
            int [] nums =  new int[4];

            try
            {
                Console.WriteLine("Before exception.");

                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}] : {1}", i, nums);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Index outside bounds.");
            }

            Console.WriteLine("End Exception.");
        }
    }
}
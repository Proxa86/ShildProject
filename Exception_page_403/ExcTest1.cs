using System;

namespace Exception_page_403
{
    public class ExcTest1
    {
        public static void GenException()
        {
            int [] nums =  new int[4];

            Console.WriteLine("Before exception.");

            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0} : {1}", i, nums[i]);
            }
        }
    }
}
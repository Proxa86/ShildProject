using System;

namespace Exception_page_403
{
    public class ExcTest
    {
        public static void Page_407()
        {
            int [] nums = new int[4];

            Console.WriteLine("Before exeption.");
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums[{0}] : {1}", i, nums[i]);
            }
        }
    }
}
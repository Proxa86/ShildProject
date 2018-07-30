using System;

namespace Exception_page_403
{
    public class ExcDemol
    {
        public void Page_405()
        {
            int [] nums =  new int[4];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    nums[i] = i;
                    Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
                }
                  
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of border array");
            }

            Console.WriteLine("End block exception.");
        }
    }
}
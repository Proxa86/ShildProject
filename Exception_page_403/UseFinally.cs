using System;

namespace Exception_page_403
{
    public class UseFinally
    {
        public static void GenException(int what)
        {
            int t = 0;
            int [] nums =  new int[2];

            Console.WriteLine("Get "+ what);
            try
            {
                switch (what)
                {
                        case 0:
                            t = 10 / what;
                            break;
                        case 1:
                            nums[4] = 4;
                            break;
                        case 2:
                            return;
                                
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide on null forbidden!");
                return;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index outside bounds!");
            }
            finally
            {
                Console.WriteLine("Exception end.");
                Console.WriteLine();
            }
            
        }
    }
}
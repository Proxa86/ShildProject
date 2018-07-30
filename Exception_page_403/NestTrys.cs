using System;

namespace Exception_page_403
{
    public class NestTrys
    {
        public void Page_413()
        {
            int[] numer = {4, 8, 16, 32, 64, 128, 256, 512};
            int[] denom = {2, 0, 4, 4, 0, 8};
            try
            {
                for (int i = 0; i < numer.Length; i++)
                {
                    try
                    {
                        Console.WriteLine(numer[i] + " / " + denom[i] + " = " + numer[i] / denom[i]);
                    }
                    catch (DivideByZeroException e)
                    {
                        Console.WriteLine("Divide on null forbidden.");
                    }
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Necessary element don't found.");
                Console.WriteLine("Error, programm interrupted.");
            }
            
        }
    }
}
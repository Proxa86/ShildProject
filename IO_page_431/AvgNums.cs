using System;

namespace IO_page_431
{
    public class AvgNums
    {
        private string str = "";
        private int n = 0;
        private double sum = 0.0;
        private double avg = 0.0, t = 0.0;
        public void Page_471()
        {
            Console.WriteLine("How number you want enter: ");
            str = Console.ReadLine();
            try
            {
                if(str != null)
                    n = int.Parse(str);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("Enter " + n + " number.");

            for (int i = 0; i < n; i++)
            {
                Console.Write(": ");
                str = Console.ReadLine();
                try
                {
                    //first variant
//                    if(str != null)
//                        t = Double.Parse(str);
                    // second variant
                    if(!Double.TryParse(str, out t))
                        Console.WriteLine("Error. Don't parse src.");

                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    t = 0.0;
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    t = 0.0;
                }

                sum += t;
            }

            avg = sum / n;
            Console.WriteLine("Avg: " + avg);
        }
    }
}
using System;

namespace Exception_page_403
{
    public class UseExcept
    {
        public void Page_419()
        {
            try
            {
                ExcTest1.GenException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Standart message: ");
                Console.WriteLine(e);
                Console.WriteLine("Property StackTrace: "+ e.StackTrace);
                Console.WriteLine("Property Message: "+ e.Message);
                Console.WriteLine("Property TargetSite: "+ e.TargetSite);
                Console.WriteLine("End exception.");
            }
        }
    }
}
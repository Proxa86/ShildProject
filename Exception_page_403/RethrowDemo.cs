using System;

namespace Exception_page_403
{
    public class RethrowDemo
    {
        public void Page_415()
        {
            try
            {
                Rethrow.GenException();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Error, programm is interrupled.");
            }
        }
    }
}
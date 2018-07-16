using System;

namespace IO_page_431
{
    public class ErrOut
    {
        private int a = 10, b = 0;
        private int _result;
        public void Page_440()
        {
            Console.Out.WriteLine("Div on null will_lead (приведет) to error");
            try
            {
                _result = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.Error.WriteLine("message: "+ ex.Message);
            }
        }
    }
}
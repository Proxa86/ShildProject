using System;

namespace Exception_page_403
{
    public class CheckedBlocks
    {
        public void Page_429()
        {
            byte a, b, result;
            a = 127;
            b = 127;
            try
            {
                unchecked
                {
                    a = 127;
                    b = 127;
                    result = unchecked ((byte) (a * b));
                    Console.WriteLine("Unchecked result overflow: "+ result);

                    a = 125;
                    b = 5;
                    result = unchecked ((byte) (a * b));
                    Console.WriteLine("Unchecked result overflow: "+ result);
                    
                }

                checked
                {
                    a = 2;
                    b = 5;
                    result = checked((byte) (a * b));
                    Console.WriteLine("Checked result overflow: "+ result);


                    a = 127;
                    b = 127;

                    result = checked((byte) (a * b));
                    Console.WriteLine("Checked result overflow: "+ result);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
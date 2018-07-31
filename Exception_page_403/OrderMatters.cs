using System;

namespace Exception_page_403
{
    public class OrderMatters
    {
        public void Page_426()
        {
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    if(i == 0) throw new ExceptA("Catch exception type ExceptA");
                    else if (i == 1) throw new ExceptB("Catch exception type ExceptB");
                    else throw new Exception();
                }
                catch (ExceptB e)
                {
                    Console.WriteLine(e);
                }
                catch (ExceptA e)
                {
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
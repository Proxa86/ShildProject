using System;

namespace Inheritance_page_329
{
    public class BoxingDemo
    {
        public void Page_370()
        {
            int x;
            object obj;

            x = 10;
            obj = x;
            int y = (int) obj;
            Console.WriteLine(y);
        }
    }
}
using System;

namespace Inheritance_page_329
{
    public class B1:A
    {
        new int i;

        public B1(int b)
        {
            i = b;
        }

        public void Show()
        {
            Console.WriteLine("Member in arbitrary class: "+ i);
        }
    }
}
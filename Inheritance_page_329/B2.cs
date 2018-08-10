using System;

namespace Inheritance_page_329
{
    public class B2: A2
    {
        private new int i;

        public B2(int a, int b)
        {
            base.i = a;
            i = b;
        }

        new public void Show()
        {
            base.Show();
            Console.WriteLine("Member i in arbitrary class: " + i);
        }
    }
}
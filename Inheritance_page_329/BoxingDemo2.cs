using System;
using System.Runtime.Remoting.Messaging;

namespace Inheritance_page_329
{
    public class BoxingDemo2
    {
        public void Page_371()
        {
            int x;
            x = 10;

            Console.WriteLine("Meaning x equals: "+ x);

            x = Sqr(x);
            Console.WriteLine("Meaning x in sqr equals: "+ x);
        }

        static int Sqr(object o)
        {
            return (int) o * (int) o;
        }
            
    }
}
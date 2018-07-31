using System;

namespace Exception_page_403
{
    public class NREDemo
    {
        public void Page_421()
        {
            X p =  new X(10);
            X q = null;
            int val = 0;
            try
            {
                val = p.Add(q);
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine("Exception NullReferenceException.");
                Console.WriteLine("Correction excrption.");
                
                q = new X(9);
                val = p.Add(q);
            }

            Console.WriteLine("Meaning val equalse " + val);
        }
    }
}
using System;

namespace Interface_struct_enum_page_375
{
    public class SeriesDemo2
    {
        public void Page_382()
        {
            ByTwos twoOb = new ByTwos();
            Primes primeOb =  new Primes();

            ISeries ob;

            for (int i = 0; i < 5; i++)
            {
                ob = twoOb;
                Console.WriteLine("Next even number: "+ ob.GetNext());

                ob = primeOb;
                Console.WriteLine("Next primes number: "+ ob.GetNext());
            }
        }
    }
}
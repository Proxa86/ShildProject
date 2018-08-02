using System;

namespace Interface_struct_enum_page_375
{
    public class Primes_main
    {
        public void Page_380()
        {
            Primes pr =  new Primes();

            for(int i = 0; i < 15; i++)
                Console.WriteLine("Primes: "+ pr.GetNext());
            
            pr.Reset();
            pr.SetStart(300);
            Console.WriteLine("We stend start number 300: ");
            for(int i = 0; i < 15; i++)
                Console.WriteLine("Primes: "+ pr.GetNext());
            
        }
    }
}
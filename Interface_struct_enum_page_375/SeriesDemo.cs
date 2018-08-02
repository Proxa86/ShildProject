using System;
using System.Data;

namespace Interface_struct_enum_page_375
{
    public class SeriesDemo
    {
        public void Page_378()
        {
            ByTwos ob =  new ByTwos();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Next number equals "+ ob.GetNext());
            }

            Console.WriteLine("Make reset.");
            ob.Reset();
            
            for( int i = 0; i < 5; i++)
                Console.WriteLine("Next number equals "+ ob.GetNext());

            Console.WriteLine("Stand start number.");
            ob.SetStart(100);
                
            for( int i = 0; i < 5; i++)
                Console.WriteLine("Next number equals "+ ob.GetNext());
        }
        
       
    }
}
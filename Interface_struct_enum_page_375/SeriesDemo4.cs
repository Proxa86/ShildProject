using System;

namespace Interface_struct_enum_page_375
{
    public class SeriesDemo4
    {
        public void Page_386()
        {
            ByTwos3 byTwos3 =  new ByTwos3();
            
            for( int i = 0; i < 5; i++)
                Console.WriteLine("Next number equals: "+byTwos3.Next);
                
            Console.WriteLine("Stand number 21.");
            byTwos3.Next = 21;

            Console.WriteLine("Reset number 0.");
            byTwos3.Next = 0;

            Console.WriteLine("Next number giv across idexcer.");
            
            for( int i = 0; i < 5; i++)
                Console.WriteLine("Next number equals: "+ byTwos3[i]);
        }
    }
}
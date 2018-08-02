using System;

namespace Interface_struct_enum_page_375
{
    public class SeriesDemo3
    {
        public void Page_384()
        {
            ByTwos2 byTwos2 = new ByTwos2();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Next number equals: "+ byTwos2.Next);
            }

            byTwos2.Next = 21;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Next number equals: "+ byTwos2.Next);
            }
            
        }
    }
}
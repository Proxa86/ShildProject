using System;

namespace Exception_page_403
{
    public class RangeArrayDemo
    {
        public void Page_423()
        {
            try
            {
                RangeArray ra =  new RangeArray(-5,5);
                RangeArray ra2 =  new RangeArray(1, 10);

                Console.WriteLine("Length arroy ra: "+ ra.Length);
                for (int i = -5; i < 5; i++)
                    ra[i] = i;

                Console.WriteLine("Content array ra: ");
                for(int i = -5; i < 5; i++)
                    Console.Write(ra[i]+ " ");
                
                Console.WriteLine();
                
                Console.WriteLine("Length arroy ra2: "+ ra2.Length);
                for (int i = -5; i < 5; i++)
                    ra2[i] = i;

                Console.WriteLine("Content array ra2: ");
                for(int i = -5; i < 5; i++)
                    Console.Write(ra2[i]+ " ");

            }
            catch (RangeArrayException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Present any error.");

            try
            {
                RangeArray ra3 =  new RangeArray(100, -10);
            }
            catch (RangeArrayException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("If stand incorrect index.");

            try
            {
                RangeArray ra4 =  new RangeArray(-2,2);

                for (int i = -2; i < 2; i++)
                    ra4[i] = i;
                Console.WriteLine("Content array ra4: ");
                for(int i = -2; i < 10; i++)
                    Console.Write(ra4[i]+" ");
            }
            catch (RangeArrayException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
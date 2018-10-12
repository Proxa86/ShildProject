using System;

namespace Operator_page_97
{
    public class Encode
    {
        public void Page_113()
        {
            char ch1 = 'H', ch2 = 'e', ch3 = 'l', ch4 = 'l', ch5 = 'o';
            int key = 34;

            Console.WriteLine("Start message: "+ch1+ch2+ch3+ch4+ch5);

            ch1 = (char) (ch1 ^ key);
            ch2 = (char) (ch2 ^ key);
            ch3 = (char) (ch3 ^ key);
            ch4 = (char) (ch4 ^ key);
            ch5 = (char) (ch5 ^ key);
            
            Console.WriteLine("Cipher message: "+ch1+ch2+ch3+ch4+ch5);
            
            ch1 = (char) (ch1 ^ key);
            ch2 = (char) (ch2 ^ key);
            ch3 = (char) (ch3 ^ key);
            ch4 = (char) (ch4 ^ key);
            ch5 = (char) (ch5 ^ key);
            
            Console.WriteLine("No cipher message: "+ch1+ch2+ch3+ch4+ch5);
            
        }
    }
}
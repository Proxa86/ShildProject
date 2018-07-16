using System;

namespace IO_page_431
{
    public class KbIn
    {
        private char ch;
        public void Page_437()
        {
            Console.WriteLine("Enter key, then next key ENTER");

            ch = (char)Console.Read();
            Console.WriteLine("\nYou enter key: "+ ch);
        }
    }
}
using System;
using System.IO;
using System.Net;

namespace IO_page_431
{
    public class ExistsDemo
    {
        public void Page_469()
        {
            if (File.Exists("text.txt"))
            {
                Console.WriteLine("File text is exist. He last time access : "+
                                  File.GetLastAccessTime("text.txt"));
                Console.WriteLine("File text create: "+ File.GetCreationTime("text.txt"));
                Console.WriteLine("Rec in file text "+ File.GetLastWriteTime("text.txt"));
            }
            else
            {
                Console.WriteLine("File don't exist");
            }
        }
    }
}
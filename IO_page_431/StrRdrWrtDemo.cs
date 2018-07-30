using System;
using System.IO;

namespace IO_page_431
{
    public class StrRdrWrtDemo
    {
        private StringReader strrdr = null;
        private StringWriter strwtr = null;
        
        public void Page_466()
        {
            try
            {
                strwtr = new StringWriter();
                
                for(int i = 0; i < 10; i++)
                    strwtr.WriteLine("Meaning i equals: " + i);
                
                strrdr = new StringReader(strwtr.ToString());

                string str = strrdr.ReadLine();
                while (str != null)
                {
                    str = strrdr.ReadLine();
                    Console.WriteLine(str);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error I/O " + e.Message);
            }
            finally
            {
                strrdr?.Close();
                strwtr?.Close();
            }
        }
    }
}
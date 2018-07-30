using System;
using System.IO;

namespace IO_page_431
{
    public class MemStrDemo
    {
        public void Page_465()
        {
            byte [] storage =  new byte[255];
            
            MemoryStream memstr =  new MemoryStream(storage);
            
            StreamReader strrdr =  new StreamReader(memstr);
            StreamWriter strwtr = new StreamWriter(memstr);

            try
            {
                Console.WriteLine("Write data in memory");
                for(int i = 0; i < 10; i++)
                    strwtr.WriteLine("byte [" + i + "]");
                strwtr.WriteLine(".");
                
                strwtr.Flush();
                
                // Show array storage
                foreach (char variable in storage)
                {
                    if(variable != '.')
                        Console.Write(variable);
                }

                Console.WriteLine("Read flow from strrdr");
                memstr.Seek(0, SeekOrigin.Begin);

                string str = strrdr.ReadLine();
                while (str != null)
                {
                    str = strrdr.ReadLine();
                    if(str[0] != '.')
                        Console.WriteLine(str);
                }
                    
                
            }
            catch (IOException e)
            {
                Console.WriteLine("Error I/O " + e.Message);
            }
            finally
            {
                strrdr.Close();
                strwtr.Close();
            }
        }
    }
}
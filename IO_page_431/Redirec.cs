using System;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace IO_page_431
{
    public class Redirec
    {
        private StreamWriter log_out = null;
        
        public void Page_453()
        {
            try
            {
                log_out =  new StreamWriter("logfile.txt");
                
                Console.SetOut(log_out);
                Console.WriteLine("This is start page registration.");
                for(int i = 0; i < 10; i++)
                    Console.WriteLine(i);
                Console.WriteLine("This is end page registration.");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: I/O " + e.Message);
                return;
            }
            finally
            {
                if(log_out != null) log_out.Close();
            }
        }
    }
}
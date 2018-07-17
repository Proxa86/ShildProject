using System;
using System.IO;

namespace IO_page_431
{
    public class ShowFile
    {
        private FileStream fin = null;
        private int i = 0;
        
        public void Page_444(string [] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("No count argument");
                return;
            }
            
            try
            {
                fin = new FileStream(args[0], FileMode.Open);
            }
            catch (IOException ioException)
            {
                Console.WriteLine("No open file");
                Console.WriteLine(ioException.Message);
                return;
            }

            try
            {
                do
                {
                    i = fin.ReadByte();
                    if(i != -1)
                        Console.WriteLine((char)i);
                } while (i != -1);
            }
            catch (IOException ioException)
            {
                Console.WriteLine("No read file!");
                Console.WriteLine(ioException.Message);
            }
            finally
            {
                fin.Close();
            }
        }

        public void Page_445(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Don't count arguments");
                return;
            }

            try
            {
                fin = new FileStream(args[0], FileMode.Open);

                do
                {
                    i = fin.ReadByte();
                    if (i != -1)
                        Console.WriteLine((char) i);
                } while (i != -1);
            }
            catch (IOException ioException)
            {
                Console.WriteLine("You incorect I/O " + ioException.Message);
            }
            finally
            {
                if(fin != null)
                    fin.Close();
            }
        }
    }
}
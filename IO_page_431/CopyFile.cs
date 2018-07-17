using System;
using System.IO;

namespace IO_page_431
{
    public class CopyFile
    {
        private int i = 0;
        private FileStream fin = null, fout = null;
        public void Page_448(string [] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("You indicate incorrect count argument");
                return;
            }

            try
            {
                fin = new FileStream(args[0], FileMode.Open);
                fout = new FileStream(args[1], FileMode.Create);

                do
                {
                    i = fin.ReadByte();
                    if(i != -1) fout.WriteByte((byte)i);
                    
                } while (i != -1);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error I/O " + e.Message);
            }
            finally
            {
                if(fin != null) fin.Close();
                if(fout != null) fout.Close();
            }
        }
    }
}
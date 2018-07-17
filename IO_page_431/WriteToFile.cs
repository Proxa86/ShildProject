using System;
using System.IO;

namespace IO_page_431
{
    public class WriteToFile
    {
        private FileStream fout = null;
        public void Page_447()
        {
            try
            {
                fout =  new FileStream("text.txt", FileMode.CreateNew);
                for (char c = 'A'; c < 'Z'; c++)
                {
                    fout.WriteByte((byte)c);
                }
            }
            catch (IOException ioException)
            {
                Console.WriteLine("Error IO " + ioException.Message);
            }
            finally
            {
                if(fout != null)
                    fout.Close();
            }
        }
    }
}
using System;
using System.IO;

namespace IO_page_431
{
    public class RandomAccessDemo
    {
        private FileStream f = null;
        private char ch = 'A';
        
        public void Page_462()
        {
            try
            {
                f =  new FileStream("random.dat", FileMode.Create);
                
                for(int i = 0; i < 26; i++)
                    f.WriteByte((byte)('A'+i));

                f.Seek(0, SeekOrigin.Begin);
                ch = (char) f.ReadByte();
                Console.WriteLine("First letter: "+ ch);

                f.Seek(1, SeekOrigin.Begin);
                ch = (char) f.ReadByte();
                Console.WriteLine("Second letter: "+ ch);

                f.Seek(2, SeekOrigin.Begin);
                ch = (char) f.ReadByte();
                Console.WriteLine("Third letter: "+ ch);

                Console.WriteLine();

                Console.WriteLine("Letter cross one.");

                // Variant first
//                for (int i = 0; i < 26; i+=2)
//                {
//                    f.Seek(i, SeekOrigin.Begin);
//                    ch = (char) f.ReadByte();
//                    Console.Write(ch + " ");
//                }
                // Variant second
                for (int i = 0; i < 26; i+=2)
                {
                    f.Position = i;
                    ch = (char) f.ReadByte();
                    Console.WriteLine(ch + " ");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error I/O " + e.Message);
            }
            finally
            {
                f?.Close();
            }
        }
    }
}
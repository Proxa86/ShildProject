using System;
using System.IO;

namespace IO_page_431
{
    public class Dtos
    {
        private string str = "";
        private FileStream fin = null;
        
        public void Page_451()
        {
            try
            {
                fin =  new FileStream("text.txt", FileMode.Open);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: don't open file " + e.Message);
                return;
            }
            
            StreamReader fstr_in =  new StreamReader(fin);
            try
            {
                while ((str = fstr_in.ReadLine()) != null)
                {
                    Console.WriteLine(str);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error I/O " + e.Message);
                return;
            }
            finally
            {
                fstr_in.Close();
            }
        }
        
        public void Page_452()
        {
            
            
            StreamReader fstr_in =  new StreamReader("text.txt");
            try
            {
                while (!fstr_in.EndOfStream)
                {
                    str = fstr_in.ReadLine();
                    Console.WriteLine(str);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error I/O " + e.Message);
                return;
            }
            finally
            {
                fstr_in.Close();
            }
        }
    }
}
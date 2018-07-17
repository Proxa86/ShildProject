using System;
using System.IO;

namespace IO_page_431
{
    public class KtoD
    {
        private string str = "";
        private FileStream fout = null;
        public void Page_449()
        {
            try
            {
                fout = new FileStream("text.txt", FileMode.Create);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: Don't open file!/n"+e);
                return;
            }
            
            StreamWriter fstr_out = new StreamWriter(fout);

            try
            {
                Console.WriteLine("Enter text, then presskey 'стоп'");
                do
                {
                    Console.Write(": ");
                    str = Console.ReadLine();
                    if (str != "стоп")
                    {
                        str = str + "\r\n";
                        fstr_out.Write(str);
                    }
                        
                } while (str != "стоп");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error I/O: " + e);
                return;
            }
            finally
            {
                fstr_out.Close();
            }
            
            
        }

        private StreamWriter fstr_out = null;
        public void Page_450()
        {
            try
            {
                fstr_out =  new StreamWriter("text.txt", true); // если указать true, то дозаписывает, 
                                                                // иначе если ничего не указать - перезапись
                
                Console.WriteLine("Enter text, then presskey 'стоп'");
                do
                {
                    Console.Write(": ");
                    str = Console.ReadLine();
                    if (str != "стоп")
                    {
                        str = str + "\r\n";
                        fstr_out.Write(str);
                    }
                        
                } while (str != "стоп");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error I/O: " + e);
                return;
            }
            finally
            {
                fstr_out.Close();
            }
        }
    }
}
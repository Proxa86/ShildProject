using System;
using System.ComponentModel.Design;
using System.IO;
using System.Runtime.InteropServices;

namespace IO_page_431
{
    public class CopyFile1
    {
        public void Page_468(string [] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("You must use: CopyFile1 from to");
                return;
            }

            try
            {
                File.Copy(args[0], args[1]); // If file does not exist
                File.Copy(args[0], args[1], true); // File can create or overwritting
            }
            catch (IOException e)
            {
                Console.WriteLine("Error copy file " + e.Message);
            }
        }
    }
}
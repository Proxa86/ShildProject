using System;
using System.IO;

namespace IO_page_431
{
    public class RWData
    {
        private BinaryReader dataIn = null;
        private BinaryWriter dataOut = null;
        private int i = 10;
        private double d = 1023.56;
        private bool b = true;
        private string str = "This text";
        
        public void Page_457()
        {
            try
            {
                dataOut =  new BinaryWriter(new FileStream("testdata.txt", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: don't open file "+e.Message);
                return;
            }

            try
            {
                Console.WriteLine("Write "+ i);
                dataOut.Write(i);

                Console.WriteLine("Write "+ d);
                dataOut.Write(d);

                Console.WriteLine("Write "+ b);
                dataOut.Write(b);

                Console.WriteLine("Write "+ 12.5 * 7.5);
                dataOut.Write(12.5 * 7.5);

                Console.WriteLine("Write "+ str);
                dataOut.Write(str);
                
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: I/O "+e.Message);
                return;
            }
            finally {dataOut.Close();}

            Console.WriteLine();
            
            try
            {
                dataIn =  new BinaryReader(new FileStream("testdata.txt", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: don't open file " +e.Message);
                return;
            }

            try
            {
                i = dataIn.ReadInt32();
                Console.WriteLine("Read " + i);

                d = dataIn.ReadDouble();
                Console.WriteLine("Read " + d);

                b = dataIn.ReadBoolean();
                Console.WriteLine("Read " + b);
                
                d = dataIn.ReadDouble();
                Console.WriteLine("Read " + d);
                
                str = dataIn.ReadString();
                Console.WriteLine("Read " + str);
                
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: I/O" + e.Message);
                return;
            }
            finally
            {
                dataIn.Close();
            }
        }
    }
}
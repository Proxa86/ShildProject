using System;
using System.IO;

namespace IO_page_431
{
    public class Inventory
    {
        private BinaryReader dataIn = null;
        private BinaryWriter dataOut = null;

        private string item; // name subjects
        private int onhand = 0; // count subjects
        private double cost = 0.0; // cost subjects
        
        public void Page_459()
        {
            try
            {
                dataOut =  new BinaryWriter(new FileStream("inventory.dat", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine("Don't open file.\nReasons: "+e.Message);
                return;
            }

            try
            {
                dataOut.Write("Hammer"); // молоток
                dataOut.Write(10);
                dataOut.Write(3.95);
                
                dataOut.Write("Screwdriver"); // отвертка
                dataOut.Write(18);
                dataOut.Write(1.50);
                
                dataOut.Write("Pliers"); // плоскогубцы
                dataOut.Write(5);
                dataOut.Write(4.95);
                
                dataOut.Write("Saws"); // пилы
                dataOut.Write(8);
                dataOut.Write(8.95);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error rec in file.\nReasons: "+e.Message);
                return;
            }
            finally {dataOut.Close();}

            Console.WriteLine();

            try
            {
                dataIn =  new BinaryReader(new FileStream("inventory.dat",FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine("Don't open file.\nReasons" + e.Message);
                return;
            }

            Console.Write("Enter subject, which you have found.\n");
            string what = Console.ReadLine();
            Console.WriteLine();

            try
            {
                for (;;)
                {
                    item = dataIn.ReadString();
                    onhand = dataIn.ReadInt32();
                    cost = dataIn.ReadDouble();
                    if(item.Equals(what, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(item + ": "+ onhand + " count thing. "+
                                          "Cost: {0:C} for one thing", cost);
                        Console.WriteLine("All cost <{0}>: {1:C}.",item, cost*onhand);
                        break;
                    }
                }
            }
            catch (EndOfStreamException e) // page 461
            {
                Console.WriteLine("Subject don't found.");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: don't read file.\nReason: " +e);
                return;
            }
            finally {dataIn.Close();}
        }
    }
}
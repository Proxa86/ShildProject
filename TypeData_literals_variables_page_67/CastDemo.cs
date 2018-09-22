using System;

namespace TypeData_literals_variables_page_67
{
    public class CastDemo
    {
        public void Page_91()
        {
            double x, y;
            byte b;
            int i;
            char ch;
            uint ui;
            short s;
            long l;

            x = 10.0;
            y = 3.0;
            
            // dounble to int
            i = (int) (x / y);
            Console.WriteLine("Double_to_int. Lost data: "+ i);
            
            //int to byte
            i = 255;
            b = (byte) i;
            Console.WriteLine("Int_to_Byte. No lost data: "+ b);

            i = 257;
            b = (byte) i;
            Console.WriteLine("Int_to_Byte. Lost data: "+b);
            
            // uint to short
            ui = 32000;
            s = (short) ui;
            Console.WriteLine("Uint_to_short. No lost data: "+ s);

            ui = 64000;
            s = (short) ui;
            Console.WriteLine("Uint_to_short. Lost data: "+ ui);
            
            //long to uint
            l = 64000;
            ui = (uint) l;
            Console.WriteLine("Long_to_uint. No lost data: " + ui);

            l = -12;
            ui = (uint) l;
            Console.WriteLine("Long_to_uint. Lost data: "+ ui);
            
            // int to char
            i = 88;
            ch = (char) i;
            Console.WriteLine("Int_to_char. Result: "+ch);


        }
    }
}
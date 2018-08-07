using System;
using System.Xml.Schema;

namespace Interface_struct_enum_page_375
{
    public class EnumDemo
    {
        enum Apple{Jonathan, GoldenDel, RedDel, Winesap, Cortland, McIntosh}

        public void Page_398()
        {
            string[] color = {"red", "yellow", "red", "red", "red", "red-green"};

            Apple i;

            for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
            {
                Console.WriteLine(i+" have meaning "+ (int)i);
            }

            Console.WriteLine();

            for (i = Apple.Jonathan; i <= Apple.McIntosh; i++)
            {
                Console.WriteLine("Color sort "+ i+ " - "+ color[(int)i]);
            }
        }
    }
}
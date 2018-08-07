using System;

namespace Interface_struct_enum_page_375
{
    public class StructAssigment
    {
        public void Page_394()
        {
            MyStruct a;
            MyStruct b;

            a.x = 10;
            b.x = 20;

            Console.WriteLine("a.x = {0}, b.x = {1}", a.x, b.x);

            a = b;
            Console.WriteLine("a.x = {0}, b.x = {1}", a.x, b.x);

            b.x = 30;
            Console.WriteLine("a.x = {0}, b.x = {1}", a.x, b.x);

            
        }
    }
}
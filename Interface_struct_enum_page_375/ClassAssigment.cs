using System;

namespace Interface_struct_enum_page_375
{
    public class ClassAssigment
    {
        public void Page_394()
        {
            MyClass4 a =  new MyClass4();
            MyClass4 b =  new MyClass4();

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
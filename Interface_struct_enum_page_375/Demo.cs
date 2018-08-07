using System;

namespace Interface_struct_enum_page_375
{
    public class Demo
    {
        public void Page_389()
        {
            MyClass2 myClass2 =  new MyClass2();

            bool result = myClass2.IsEven(4);
            Console.WriteLine("4 - is even number: "+ result);

            IEven iRef = myClass2;
            result = iRef.IsOdd(3);
            Console.WriteLine("3 - is odd number: "+result);

        }
    }
}
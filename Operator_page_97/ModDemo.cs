using System;

namespace Operator_page_97
{
    public class ModDemo
    {
        public void Page_98()
        {
            var iresult = 10 / 3;
            var irem = 10 % 3;

            var dresult = 10.0 / 3.0;
            var drem = 10.0 % 3.0;

            Console.WriteLine("Result and residue div 10/3 "+iresult+" "+ irem);
            Console.WriteLine("Result and residue div 10.0/3.0 "+dresult+ " "+drem);
        }
    }
}
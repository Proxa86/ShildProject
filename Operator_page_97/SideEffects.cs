using System;
using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace Operator_page_97
{
    public class SideEffects
    {
        public void Page_105()
        {
            int i = 0;
            bool someCondition = false;
            
            
            if(someCondition & (++i < 100))
                Console.WriteLine("Meaning false");
            Console.WriteLine("i = "+ i);

            i = 0;
            if(someCondition && (++i < 100))
                Console.WriteLine("Meaning false");
            Console.WriteLine("i = "+ i);

            

        }
    }
}
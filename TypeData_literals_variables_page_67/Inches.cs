using System;

namespace TypeData_literals_variables_page_67
{
    public class Inches
    {
        public void Page_70()
        {
            long miles = 93000000;
            
            // 5280 fut in mils, 12 inches in fut
            long inches = miles * 5280 * 12;
            Console.WriteLine("Distance for Sun :" +inches + " inches");
        }
    }
}
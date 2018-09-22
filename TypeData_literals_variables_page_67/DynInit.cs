using System;

namespace TypeData_literals_variables_page_67
{
    public class DynInit
    {
        public void Page_84()
        {
            double s1 = 4.0;
            double s2 = 5.0;

            double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.WriteLine("Hypot triangle where side s1 = {0} and side s2 = {1} equals {2:#.###}.", s1, s2, hypot);

        }
    }
}
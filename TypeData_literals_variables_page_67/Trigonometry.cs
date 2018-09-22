using System;

namespace TypeData_literals_variables_page_67
{
    public class Trigonometry
    {
        public void Page_72()
        {
            double theta;
            for (theta = 0.1; theta <= 1.0; theta += 0.1)
            {
                Console.WriteLine("Sin({0}): {1}", theta, Math.Sin(theta));
                Console.WriteLine("Cos({0}): {1}",theta, Math.Cos(theta));
                Console.WriteLine("Tan({0}): {1}",theta, Math.Tan(theta));
                Console.WriteLine();
            }
        }
        
    }
}
﻿using System;
using System.Data;

namespace Inheritance_page_329
{
    public class GeneticDemo
    {
        public void Page_372()
        {
            object [] ga = new object[10];

            for (int i = 0; i < 3; i++)
                ga[i] = i;

            for (int i = 3; i < 6; i++)
                ga[i] = (double) i/2;

            ga[6] = "Hello";
            ga[7] = true;
            ga[8] = 'X';
            ga[9] = "End";
            
            for(int i = 0; i < ga.Length; i++)
                Console.WriteLine("ga["+i+"]: "+ga[i]+" ");
        }
        
        
        
    }
}
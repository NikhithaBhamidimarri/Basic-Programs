﻿using System;
using System.Collections.Generic;
using System.Text;


namespace BasicPrograms
{
    public class Largestof3
    {
        public void largest()
        {
            int num1, num2, num3;
            Console.Write("Enter the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three");
            else
                Console.Write("The 3rd Number is the greatest among three");
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;


namespace BasicPrograms
{
    public class FlipCoin
    {
        public void flipCoinPercentage()
        {
            Console.WriteLine("Welcome to Flip Coin Percentage Program ");
            int count = 0;
            int tails = 0;
            int heads = 0;
            while (count < 100)
            {
                Random rnd = new Random();
                int result = rnd.Next(0, 2);
                if (result == 1)
                {
                    Console.WriteLine("Tails!");
                    tails = tails + 1;
                    count = count + 1;

                }
                else if (result == 0)
                {
                    Console.WriteLine("Heads!");
                    heads = heads + 1;
                    count = count + 1;
                }
            }
            Console.WriteLine("Heads Percentage = " + heads + " ,Tails Percentage = " + tails + " ,Counts = " + count);
            Console.ReadLine();

        }

    }
}
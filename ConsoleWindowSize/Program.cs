﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleWindowSize
{
    class Program
    {
        static void printHeightWidth()
        {
            Console.WriteLine("Console Heigth: {0}\nConsole Width: {1}",Console.WindowHeight, Console.WindowWidth);
        }
        static void Main(string[] args)
        {
            Console.WindowHeight = 4;
            Console.WindowWidth = 19;
            Random rnd = new Random();

            // int h = Console.WindowHeight;
            // int w = Console.WindowWidth;
            while(true)
            {
                if (!(Console.WindowHeight <= 2) && !(Console.WindowWidth <= 4))
                {
                    Console.Clear();
                }
                printHeightWidth();
                Thread.Sleep(2);

                // Console.WindowWidth = rnd.Next();
                
            }

        }
    }
}
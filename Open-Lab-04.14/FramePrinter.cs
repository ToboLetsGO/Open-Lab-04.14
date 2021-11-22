﻿using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings){
             int max_lengt = 0;
            foreach (var item in strings){if (item.Length > max_lengt){ max_lengt = item.Length; }}
            for (int i = 0; i < max_lengt+4; i++) { Console.Write("*"); }
            Console.WriteLine();
            foreach (var item in strings){
                Console.Write("* ");
                Console.Write(item);
                for (int i = 0; i < (max_lengt - item.Length); i++) { Console.Write(" ");}
                Console.WriteLine(" *");}
            for (int i = 0; i < max_lengt + 4; i++) { Console.Write("*"); }
        }
    }
}
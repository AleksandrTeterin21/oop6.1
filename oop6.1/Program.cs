﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6._1
{
    class Numbers

    {
        private int One;
        private int Two;

        public Numbers()
        {
        }



        public Numbers(int Onenum)

        {
            One = Onenum;
        }



        public Numbers(int Onenum, int Twonum)
        {
            One = Onenum;
            Two = Twonum;
        }

        public void Display()
        {
            Console.WriteLine($"{One} {Two}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Numbers Numbers = new Numbers();

            Numbers.Display();

            Numbers NumbersOne = new Numbers(1);

            NumbersOne.Display();

            Numbers NumbersTwo = new Numbers(2, 3);

            NumbersTwo.Display();



            Console.ReadLine();
        }
    }
}

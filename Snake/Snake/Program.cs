﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
             Point p1 = new Point(1, 3, '*');
             p1.Draw();

             Point p2 = new Point(4, 5, '#');
             p2.Draw();

            Point p3 = new Point(5, 6, '@');
            Point p4 = new Point(6, 7, '$');


            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[ 0 ];
            int y = numList[ 1 ];
            int z = numList[ 2 ];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            /*List<char> charList = new List<char>();
            charList.Add(0);
            charList.Add(1);
            charList.Add(2);

            char a = charList['@'];
            char b = charList['#'];
            char c = charList['*'];
            foreach (int i in charList)
            {
                Console.WriteLine(i);*/

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

            foreach (Point i in pList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();

            }
      }
}

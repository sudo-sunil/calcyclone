﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcyclone
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program p = new Program();
            p.hello();
            Console.WriteLine("Jenkins integration !");
            Console.WriteLine("Testing CI/CD !");
            Console.WriteLine("Testing 2 !");
            p.Azure();
            Console.WriteLine("USing Asure Devops !");
            p.sub();
            p.div();
            p.add();
            p.sumSquare();
            p.cube();
            p.square();
            p.demo();
            p.Hola();
            p.ProjectPpt();
            Console.ReadLine();
        }
        public void hello()
        {
            Console.WriteLine("Somethings fishy... is happening after every hour");
        }

        public void sub()
        {
            int x = 20;
            int y = 4;
            int result = x - y;
            Console.WriteLine("Subtraction is : {0}", result);
        }
        public void div()
        {
            Console.WriteLine("Enter 1st no:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            int y = int.Parse(Console.ReadLine());
            int result = x / y;
            Console.WriteLine("Div: " + result);

        }

        public void add()
        {
            Console.WriteLine("Enter 1st no:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            int y = int.Parse(Console.ReadLine());
            int result = x + y;
            Console.WriteLine("Add: " + result);
        }

        public void mul()
        {
            Console.WriteLine("Enter 1st no:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            int y = int.Parse(Console.ReadLine());
            int result = x * y;
            Console.WriteLine("Add: " + result);

        }
        public void sumSquare()
        {
            Console.WriteLine("Enter 1st no:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd no:");
            int y = int.Parse(Console.ReadLine());
            int result = (x * x) + (y * y);
            Console.WriteLine("Add: " + result);

        }

        public void cube()
        {
            Console.WriteLine("Enter a number to be cubed:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Cube of the number is : {0}",x*x*x);
        }
        public void square()
        {
            Console.WriteLine("Enter a number to be squared:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Cube of the number is : {0}", x * x );
        }
        public void demo()
        {
            Console.WriteLine("First Demo CI CD in Jenkins");
        }
        public void Hola()
        {
            Console.WriteLine("Hello in Spanish");
        }

        public void ProjectPpt()
        {
            Console.WriteLine("We won,Mission Accomplished");

        }
        public void Azure()
        {
            Console.WriteLine("Azure Devops Testing.....");
        }



    }
}

﻿using System;
using System.Globalization;

namespace CourseCsharpExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = ( b  + B ) / 2.0 * h;

            Console.WriteLine();
            Console.WriteLine(" Exercício Área de um Triângulo Equilátero ");
            Console.WriteLine();
            Console.WriteLine(" A área do Triângulo é: " + area );
            

            Console.ReadLine();
        }
    }
}


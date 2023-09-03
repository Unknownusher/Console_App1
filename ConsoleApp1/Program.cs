using System;
using System.Collections;
using System.Collections.Generic;

class main {

    static void Main(String[] args) {

        int x, y;

        Console.Write("Enter a number: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter another number: ");
        y = Convert.ToInt32(Console.ReadLine());

        int higherNumber = Max(x, y);
        int lowerNumber  = Min(x, y);

        Console.WriteLine($"\n{higherNumber} is the higher number and {lowerNumber} is the lower number.");
        Console.ReadKey();

    }

    static int Min(int x, int y) => (x < y) ? x : y;
    static int Max(int x, int y) => (x < y) ? y : x;

}
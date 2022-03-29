// Created by: Joanne Santhosh
// Created on: Mar 2022
//
// This program finds the area of a triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program finds the area of a triangle
        int baseOfTriangle;
        int heightOfTriangle;
        Console.WriteLine("This program finds the area of a triangle.");
        Console.WriteLine("");

        Console.WriteLine("Enter the base of the triangle.");
        baseOfTriangle = (Convert.ToInt32(Console.ReadLine()));
        Console.Write("Enter the height of the triangle. ");
        heightOfTriangle = (Convert.ToInt32(Console.ReadLine()));
        
        Console.WriteLine("");
        Console.WriteLine("Area is: " + (baseOfTriangle * heightOfTriangle / 2) + " cm² ");

        Console.WriteLine("\nDone.");
    }
}
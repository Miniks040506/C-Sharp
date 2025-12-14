using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ClassesAndObjects
{
    internal class Rectangle
    {
        //const field. initialize during the compile-time
        public const int numberOfCorners = 4;

        //readonly field. initialize during the run-time
        public readonly string Color;

        public double Width { get; set; }
        public double Height { get; set; }

        //compute property
        //read only -> only get
        //write only -> only set 
        public double Area
        {
            get => Width * Height;
        }

        public Rectangle(string color)
        {
            Color = color;
        }

        //static method
        //static method is the method that loaded into memory only once 
        //during the entire lifetime of the program
        public static void ShapeIntroduce(double width, double height)
        {
            Console.WriteLine($"I'm a rectangle with width = {width} and height = {height}");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Color: {Color}, Width: {Width}, " +
                $"Height: {Height}, Area: {Area}, " +
                $"Number of Corners: {numberOfCorners}");
        }
    }
}

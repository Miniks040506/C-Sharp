using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ClassesAndObjects
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        //compute property
        //read only -> only get
        //write only -> only set 
        public double Area
        {
            get => Width * Height;
        }

        //static method
        //static method is the method that loaded into memory only once 
        //during the entire lifetime of the program
        public static void ShapeIntroduce(double width, double height)
        {
            Console.WriteLine($"I'm a rectangle with width = {width} and height = {height}");
        }
    }
}

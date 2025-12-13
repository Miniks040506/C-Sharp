using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    //internal: means that it can only be accessed
    //from within the same assembly
    //(simplify is within same program).
    internal class Cars
    {
        //member variable
        //private hides the variable from other classes
        //(only this class can access)
        //object state...
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury; 
        //static field -> only loaded to the memory
        //once when Cars class loaded to memory
        //that mean all Cars Object use this field together(shared)
        public static int numberOfCars = 0; 

        //getter and setter
        //property
        public string Model { get; set; }
        //public string Model { get => _model; set => _model = value; }
        public string Brand {
            get { 
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                } else {  return _brand; }
            }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING");
                    _brand = "DEFAULTVALUE";
                } else
                {
                    _brand = value;
                }                   
            }
        }

        public bool IsLuxury { get; set; }
        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }

        //default constructor
        public Cars()
        {
            //this: current object
            numberOfCars++;
            Console.WriteLine($"An object of Car has been created!!!");
        }

        //Constructor: called when new object is
        //created by class. 

        //Custom constructor
        public Cars(string model, string brand, bool isLuxury) {
            //this: current object
            numberOfCars++;
            this.Model = model;
            this.Brand = brand;
            this.IsLuxury = isLuxury;
            Console.WriteLine($"An object of Car " +
                $"with {Brand} of the model {Model} has been created!!!");
        }
    }
}

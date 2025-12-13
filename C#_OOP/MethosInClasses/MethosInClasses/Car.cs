using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace MethosInClasses
{
    internal class Cars
    {
        //member variable
        //private hides the variable from other classes
        //(only this class can access)
        //object state...
        private string _model = "";
        private string _brand = "";
        private bool _isLuxury;

        //getter and setter
        //property
        //public string Model { get; set; }
        //expression body -> using lambda
        // public string Model { get { return _model; } }   ->   public string Name => name;
        // public string Log (string msg) { message = msg }  ->   public string Log (string) => message = msg;
        public string Model { get => _model; set => _model = value; }
        public string Brand
        {
            get
            {
                if (IsLuxury)
                {
                    return _brand + " - Luxury Edition";
                }
                else { return _brand; }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered NOTHING");
                    _brand = "DEFAULTVALUE";
                }
                else
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
            Console.WriteLine($"An object of Car has been created!!!");
        }

        //Constructor: called when new object is
        //created by class. 

        //Custom constructor
        public Cars(string model, string brand, bool isLuxury)
        {
            //this: current object
            this.Model = model;
            this.Brand = brand;
            this.IsLuxury = isLuxury;
            Console.WriteLine($"An object of Car " +
                $"with {Brand} of the model {Model} has been created!!!");
        }

        // Methods in classes -> object behaviors ...

        //public void Drive()
        //{
        //    Console.WriteLine($"I'm a {Brand}({Model}) and i'm driving");
        //}


        //expression bodied -> using lambda
        public void Drive() => Console.WriteLine($"I'm a {Brand}({Model}) and i'm driving");


        // expression bodied indexer
        private int[] numbers = { 1, 2, 3, 4, 5 };
        //public int this[int index]
        //{
        //    get { return numbers[index]; }
        //}
        public int this[int index] => numbers[index];
        

    }
}

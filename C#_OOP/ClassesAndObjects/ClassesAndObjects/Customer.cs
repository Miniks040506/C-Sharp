using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace ClassesAndObjects
{
    internal class Customer
    {
        //static field to hold the next ID available
        private static int nextId = 0;
        //read-only instance field initialized from the constructor
        private readonly int _id;

        //Read-only properties
        public int Id { get; }

        //write-only property
        private string _password;
        public string Password { set =>  _password = value; }
        //public string Password { set {
        //        _password = value;
        //    }
        //}

        //field
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        //public Customer()
        //{
        //    _id = nextId++;
        //    Name = "DefaultName";
        //    Address = "No Address";
        //    ContactNumber = "None";
        //}

        // using customer constructor with parameter to
        // set default val ue to the default constructor
        public Customer() : this("DefaultName") { }

        public Customer(string name, string address = "N/A", string contactNumber = "N/A")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        //public Customer(string name)
        //{
        //    Name = name;
        //}

        public void GetDetails()
        {
            Console.WriteLine($"Details about the customer: " +
                $"Name is {Name} and Id is {_id} " +
                $"and Password is {_password}");
        }
    }
}

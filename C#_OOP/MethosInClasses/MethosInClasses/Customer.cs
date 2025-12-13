using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace MethosInClasses
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            Name = "DefaultName";
            Address = "No Address";
            ContactNumber = "None";
        }

        //public Customer(string name, string address, string contactNumber)
        //{
        //    Name = name;
        //    Address = address;
        //    ContactNumber = contactNumber;
        //}

        //option parameters
        public Customer(string name, string address = "N/A", string contactNumber = "N/A")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        //public Customer(string name)
        //{
        //    Name = name;
        //}

        //define contactNumber : default parameter
        //-> option parameter
        public void SetDetails(string name, string address, string contactNumber = "N/A")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}

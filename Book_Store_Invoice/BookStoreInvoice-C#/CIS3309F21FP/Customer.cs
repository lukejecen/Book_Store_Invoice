using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309F21FP
{
    public class Customer
    {
        private int customerId;
        private string name;
        private string address;
        private string city;
        private string state;
        private string zipCode;

        public Customer() { }

        public Customer(int customerId, string name, string address, string city, string state,
            string zipCode)
        {
            this.CustomerId = customerId;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }

        public int CustomerId
        {
            get
            {
                return customerId;
            }
            set
            {
                customerId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }

        public override string ToString()
        {
            string s = CustomerId + " " + Name + " " + Address + " " + City + " " +
               State + " " + ZipCode;
            return s;
        }
    }
}

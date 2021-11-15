using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionDemo
{
    class Customer
    {

        public int Id { get; set; }
        public string name { get; set; }

        public Customer(int id, string name)
        {
            this.Id = Id;
            this.name = name;
        }
        public Customer()
        {
            this.Id = -1;
            this.name = string.Empty;
        }
    }
}

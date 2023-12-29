using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        

        public void PrintName()
        {
            Console.WriteLine($"My name is\t {FirstName}");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }

    }
}

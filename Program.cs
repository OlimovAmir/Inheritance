﻿using Inheritance;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Person person = new Person { FirstName = "Ilhom", LastName="Olimov", Age = 39 };

        person.PrintName();

        Console.WriteLine(person);

        Student student = new Student 
        {
            FirstName = "Parvina",
            LastName = "Olimova",
            Age = 31,
        };

        student.PrintName();
    }
}
using Inheritance;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Person person = new Person { FirstName = "Ilhom", LastName = "Olimov", Age = 39 };

        person.PrintName();

        Console.WriteLine(person);

        Student student = new Student
        {
            FirstName = "Parvina",
            LastName = "Olimova",
            Age = 31,
        };

        student.PrintName();

        Teacher teacher = new Teacher
        {
            Age = 65,
            FirstName = "Olimova",
            LastName = "Muborak",

        };

        Person[] people = { student, teacher };

        PrintPerson(people);   


        
        static void PrintPerson(Person[] person)
        {
            foreach (Person p in person)
            {
                p.PrintFullName();
            }
        }

    }
    };
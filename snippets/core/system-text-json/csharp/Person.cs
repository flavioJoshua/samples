﻿using System;
using System.Collections.Generic;

namespace SystemTextJsonSamples
{
    // <SnippetPerson>
    public class Person
    {
        public string Name { get; set; }
    }

    public class Customer : Person
    {
        public decimal CreditLimit { get; set; }
    }

    public class Employee : Person
    {
        public string OfficeNumber { get; set; }
    }
    // </SnippetPerson>

    public static class PersonExtensions
    {
        public static void DisplayPropertyValues(this Person person)
        {
            Utilities.DisplayPropertyValues(person);
            Console.WriteLine();
        }
    }

    public static class PersonFactories
    {
        public static List<Person> CreatePeople()
        {
            var people = new List<Person>
            {
                new Customer { CreditLimit = 10000, Name = "John" },
                new Employee { OfficeNumber = "555-1234", Name = "Nancy" }
            };
            return people;
        }
    }
}


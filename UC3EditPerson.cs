﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class EditPerson
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int ZipCode { get; set; }
        public Double PhoneNumber { get; set; }
        public String Email { get; set; }

        public void AddPerson()
        {
            EditPerson person = new EditPerson();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Address : ");
            Address = Console.ReadLine();

            Console.Write("Enter city: ");
            person.City = Console.ReadLine();

            Console.Write("Enter the state: ");
            person.State = Console.ReadLine();

            Console.Write("zipCode: ");
            person.ZipCode = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();

            List<EditPerson> People = new List<EditPerson>();
            People.Add(person);


            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address 1: " + person.Address);
            Console.WriteLine("city: " + person.City);
            Console.WriteLine("city: " + person.State);
            Console.WriteLine("zipCode: " + person.ZipCode);
            Console.WriteLine("Email: " + person.Email);


        }

    }

}
    


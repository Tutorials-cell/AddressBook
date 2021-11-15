using System;

namespace AddressBook
{
    internal class ContactPerson
    {
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string Adress { get; internal set; }
        public string City { get; internal set; }
        public string State { get; internal set; }
        public int ZipCode { get; internal set; }
        public double PhoneNumber { get; internal set; }
        public string Email { get; internal set; }

        internal void displaycontact()
        {
            throw new NotImplementedException();
        }
    }
}
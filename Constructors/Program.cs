using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Fatih";
            customer3.LastName = "Hacıoğlu";
            customer3.City = "Rize";

            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        //Default Constructor
        public Customer()
        {

        }

        public Customer(int id, string firstName, string lastName, string city) //parametre belirtirsek default'u ezmiş oluruz
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}

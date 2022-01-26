using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MySqlCustomerDal() };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirsName = "Engin",
                LastName = "Demiroğ",
                Adress = "Ankara"
            };

            Student student = new Student();
            student.Id = 1;
            student.FirsName = "Derin";
            student.LastName = "Demiroğ";
            student.Departmant = "Computer Sciences";

            personManager.Add(customer);
            personManager.Add(student);
        }
    }

    //Soyut Nesne
    interface IPerson
    {
        int Id { get; set; }
        string FirsName { get; set; }
        string LastName { get; set; }
    }

    //Somut Nesne
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirsName);
        }
    }
}

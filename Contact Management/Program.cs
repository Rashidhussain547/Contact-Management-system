using System;
using System.Collections.Generic;

// Contact Management System

namespace ContactManagement
{
    class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
    class program
    {
        static List<Contact> list = new List<Contact>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine("Contact Management system");
                Console.WriteLine("1. Add contact");
                Console.WriteLine("2. View contact");
                Console.WriteLine("3. Search Contact");
                Console.WriteLine("4. Delete contact");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddContact();
                        break;
                    case 2:
                        ViewContact();
                        break;
                    case 3:
                        SearchContact();
                        break;
                    case 4:
                        DeleteContact();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine("Invalid option has been entered by the user...!!");
                        break;
                }

            }
        }
        static void AddContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Add Contact");
            Console.WriteLine("Enter name of contact");
            contact.Name = Console.ReadLine();
            Console.WriteLine("Enter contact number");
            contact.PhoneNumber =Console.ReadLine();
            Console.WriteLine("Enter email of contact");
            contact.Email = Console.ReadLine();

            list.Add(contact);

        }
        static void ViewContact()
        {
            Console.WriteLine("View contacts");
            foreach (Contact view in list)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"Name: {view.Name}, Phone number: {view.PhoneNumber}, Email: {view.Email}");
                

            }
        }
        static void SearchContact()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Type for search: ");
            string searchkey = Console.ReadLine();
            foreach (Contact search in list) 
            {
                if (search.Name.Contains(searchkey) || search.PhoneNumber.Contains(searchkey) || search.Email.Contains(searchkey))
                {
                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine($"Name: {search.Name}, Phone number: {search.PhoneNumber}, Email: {search.Email}");
                 
                }
                else
                {
                    Console.WriteLine("Enter valid information");
                }
            }
        }
        static void DeleteContact()
        {
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Type Contact information to delete: ");
            string searchkey = Console.ReadLine();
            try
            {
                foreach (Contact delete in list)
                {
                    if (delete.Name.Contains(searchkey) || delete.PhoneNumber.Contains(searchkey) || delete.Email.Contains(searchkey))
                    {
                        list.Remove(delete);
                        Console.WriteLine("Contact has been deleted");
                    }
                    else
                {
                    Console.WriteLine("Enter valid information");
                }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


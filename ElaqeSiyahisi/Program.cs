using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElaqeSiyahisi
{
    internal class Program
    {
        static void Main(string[] args)
            {
            List<Contact> contacts = new List<Contact>();

              while (true)
              {
                    Console.WriteLine("1. Add contact");
                    Console.WriteLine("2. Delete contact");
                    Console.WriteLine("3. Show contacts");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddContact(contacts);
                            break;
                        case "2":
                            DeleteContact(contacts);
                            break;
                        case "3":
                            ShowContacts(contacts);
                            break;
                        case "4":
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                    Console.WriteLine();
              }
            }

            static void AddContact(List<Contact> contacts)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                Console.Write("Enter phone number: ");
                string phoneNumber = Console.ReadLine();

                Contact contact = new Contact()
                {
                    Name = name,
                    PhoneNumber = phoneNumber
                };

                contacts.Add(contact);

                Console.WriteLine("Contact added.");
            }

            static void DeleteContact(List<Contact> contacts)
            {
                Console.Write("Enter name of contact to delete: ");
                string name = Console.ReadLine();

                Contact contactToDelete = contacts.Find(c => c.Name == name);

                if (contactToDelete != null)
                {
                    contacts.Remove(contactToDelete);
                    Console.WriteLine("Contact deleted.");
                }
                else
                {
                    Console.WriteLine("Contact not found.");
                }
            }

            static void ShowContacts(List<Contact> contacts)
            {
                if (contacts.Count == 0)
                {
                    Console.WriteLine("No contacts.");
                }
                else
                {
                    foreach (Contact contact in contacts)
                    {
                        Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
                    }
                }
            }

    }

}
  

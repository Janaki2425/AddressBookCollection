using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace addressbook

{
    internal class AddContact
    {
        public static List<ContactDetails> AddressBook = new List<ContactDetails>();
        public static Dictionary<string, List<ContactDetails>> person = new Dictionary<string, List<ContactDetails>>();
        public static Dictionary<string, List<ContactDetails>> City = new Dictionary<string, List<ContactDetails>>();
        public static Dictionary<string, List<ContactDetails>> State = new Dictionary<string, List<ContactDetails>>();

        public void EnterInput()

        {
            Console.WriteLine("enter how many contacts you want to add");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                ContactDetails contacts = new ContactDetails();
                Console.WriteLine("Enter the First name:");
                contacts.FirstName = Console.ReadLine();
                foreach (var item in AddContact.AddressBook)

                    while (true)
                    {

                        if (contacts.FirstName.ToLower() != item.FirstName.ToLower())
                        {
                            Console.WriteLine(contacts.FirstName);
                            break;

                        }

                        else
                        {
                            Console.WriteLine("First name already exists!! Duplicate Element not allowed.");


                        }
                    }
                Console.WriteLine("Enter the last Name  : ");
                contacts.LastName = Console.ReadLine();

                Console.WriteLine("Enter the address  : ");
                contacts.Address = Console.ReadLine();

                Console.WriteLine("Enter the City  : ");
                contacts.City = Console.ReadLine();

                Console.WriteLine("Enter the state : ");
                contacts.State = Console.ReadLine();


                while (true)
                {
                    Console.WriteLine("Enter Zip Code  : ");
                    string code = Console.ReadLine();

                    if (code.Length == 6)
                    {
                        contacts.Zip = code;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid 6 digit Zip Code.");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter Your Phone Number: ");
                    string number = Console.ReadLine();

                    if (number.Length == 10)
                    {
                        contacts.PhoneNumber = number;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid 10 digit Phone Number.");
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter Your Email Address: ");
                    string mail = Console.ReadLine();

                    if (mail.Contains("@"))
                    {
                        contacts.Email = mail;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter a valid Email Address.");
                    }
                }

                AddressBook.Add(contacts);

                Console.WriteLine("..................");

            }


        }



        public void ViewTheDetails()
        {
            if (AddressBook.Count > 0)
            {
                foreach (var item in AddressBook)
                {
                    PrintTheDetails(item);

                }
            }
            else
            {
                Console.WriteLine("Address book is empty! ");

            }




        }

        public void PrintTheDetails(ContactDetails item)
        {
            Console.WriteLine("First Name :   " + item.FirstName);
            Console.WriteLine("Last Name :    " + item.LastName);
            Console.WriteLine("Address :      " + item.Address);
            Console.WriteLine("City    :      " + item.City);
            Console.WriteLine("State   :      " + item.State);
            Console.WriteLine("Zip     :      " + item.Zip);
            Console.WriteLine("Phone Number  : " + item.PhoneNumber);
            Console.WriteLine("email  :       " + item.Email);


        }

        public static void SearchAddress(int option)
        {
            string city = "", state = "";
            if (option == 1)
            {
                Console.WriteLine("Enter the City Name");
                city = Console.ReadLine();
            }
            if (option == 2)
            {
                Console.WriteLine("Enter the City Name");
                state = Console.ReadLine();
            }

            //Iterate through all Address Book present in Dictionary
            foreach (KeyValuePair<string, List<ContactDetails>> kvp in person)
            {
                if (option == 1)
                {
                    StoreCity(kvp.Key, kvp.Value, city);
                }
                if (option == 2)
                {
                    StoreState(kvp.Key, kvp.Value, state);
                }

                static void StoreCity(string key, List<ContactDetails> ContactArray, string city)
                {
                    List<ContactDetails> CityList = ContactArray.FindAll(x => x.City.Equals(city)).ToList();
                    foreach (var i in CityList)
                    {
                        Console.WriteLine("Found person \"{0}\" in Address Book \"{1}\" , residing in City {2}", i.FirstName, key, i.City);
                    }
                }
                static void StoreState(string key, List<ContactDetails> ContactArray, string state)
                {
                    List<ContactDetails> StateList = ContactArray.FindAll(x => x.state.Equals(state)).ToList();
                    foreach (var i in StateList)
                    {
                        Console.WriteLine("Found person \"{0}\" in Address Book \"{1}\" , residing in State {2}", i.FirstName, key, i.State);
                    }
                }
            }
        }
    }
}
    




    




/*
 * Phonebook: Shows the use of a dictionary and how to add, remove, and find different numbers throughout
 * Name: Spencer Unitt
 * Module: Lab 12
 * 
 * Algoritm:
 * 1. Create a new dictionary called phonebook that will hold a string and int key value pair
 * 2. Create a function to add a value to the dictionary
 * 3. Create a function that will remove and find a function as well
 * 4. Display the phonebook to the user
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new phonebook
            Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            
            // calls function that will add the name and number to the phonebook
            addNum("Betty Ross", 4893829384);
            addNum("Ross Geller", 123456789);
            addNum("Maple Mellow", 182947382);

            // cycles through the phonebook and prints out the contents
            foreach(KeyValuePair<string, long> people in phoneBook)
            {
                Console.WriteLine(("Name: {0}, Number {1}"), people.Key, people.Value);
            }
            Console.WriteLine("\n");
            // removes the name in the phonebook if its there
            removeValue("Ross Geller");

            // shows if the value above was removed or not
            foreach (KeyValuePair<string, long> people in phoneBook)
            {
                Console.WriteLine(("Name: {0}, Number {1}"), people.Key, people.Value);
            }
            Console.WriteLine("\n");

            // searchs the phonebook for a name in a specific location. If its not there it returns null
            findValue(2);
            findValue(0);

            Console.ReadLine();

            // adds values to the phonebook
            void addNum(string n, long num)
            {
                phoneBook[n] = num;
            }

            // removes the value from the phonebook
            void removeValue(string n)
            {
                if(phoneBook.ContainsKey(n))
                {
                    phoneBook.Remove(n);
                }   
            }

            // searches through the phonebook for a specific value and returns true or false
            void findValue(long num)
            {
                if(phoneBook.ContainsValue(num))
                {
                    Console.WriteLine("Number is found in the phonebook.\n");
                }
                else
                {
                    Console.WriteLine("Number is not in the phonebook.");
                }
            }
            
        }

    }
}


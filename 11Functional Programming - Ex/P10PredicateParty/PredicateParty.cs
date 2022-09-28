using System;
using System.Collections.Generic;
using System.Linq;

namespace P10PredicateParty
{
    internal class PredicateParty
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate;
            Action<List<string>> print = names => Console.WriteLine(String.Join(", ", names) + " are going to the party!");

            List<string> guests = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input != "Party!")
            {

                //Remove StartsWith 
                string[] commandsArgs = input.Split();

                string command = commandsArgs[0];
                string predicateName = commandsArgs[1];
                string value = commandsArgs[2];

                predicate = GetPredicate(predicateName, value);

                if (command == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else
                {
                    var newGuests = guests.FindAll(predicate);

                    foreach (var guest in newGuests)
                    {
                        int indexOfCurrGuest = guests.IndexOf(guest);

                        guests.Insert(indexOfCurrGuest + 1, guest);
                    }
                }

                input = Console.ReadLine();
            }

            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                print(guests);
            }
        }

        private static Predicate<string> GetPredicate(string predicateName, string value)
        {
            if (predicateName == "StartsWith")
            {
                return p => p.StartsWith(value);
            }
            else if (predicateName == "EndsWith")
            {
                return p => p.EndsWith(value);
            }
            else if (predicateName == "Length")
            {
                return p => p.Length == int.Parse(value);
            }
            
            return null;    
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    public class ProgramUI
    {
        OutingRepository _outingRepository = new OutingRepository();
        List<OutingMenu> listOfOutings = new List<OutingMenu>();

        List<OutingMenu> _outingTypes;

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("What would you like to do?" +
                    "\n1. Add an event" +
                    "\n2. Display all events" +
                    "\n3. View total cost of outing by type" +
                    "\n4. View total cost of all outings");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        AddOuting();
                        Console.ReadKey();
                        break;
                    case 2:
                        GetOutingMenu();
                        Console.ReadKey();
                        break;
                    case 3:
                }

            }
        }

        private void AddOuting()
        {
            OutingMenu newItem = new OutingMenu();
            Console.WriteLine("What type of outing?");
            newItem.OutingType = Console.ReadLine();

            Console.WriteLine("When did it occur?");
            newItem.OutingDate = Console.ReadLine();

            Console.WriteLine("How many people were in attendance?");
            newItem.TotalPeople = int.Parse(Console.ReadLine());

            Console.WriteLine("What was the total cost per person?");
            newItem.CostPerPerson = int.Parse(Console.ReadLine());

            Console.WriteLine("What was the total cost of the entire event?");
            newItem.TotalCost = int.Parse(Console.ReadLine());

            _outingRepository.AddOuting(newItem);
        }

        OutingMenu firstOuting = new OutingMenu("Bowling", "January 3rd and August 8th, 2017", 20, 50.00m, 2000.00m);
        OutingMenu secondOuting = new OutingMenu("Golf", "June 26 and July 17, 2017", 20, 50.00m, 200.00m);
        OutingMenu thirdOuting = new OutingMenu("Concert", "November 11 and December 14, 2017", 20, 125.00m, 5000.00m);
        OutingMenu fourthOuting = new OutingMenu("Amusement Park", "July 15, 2017", 30, 90.00m, 2700.00m);



        private void GetOutingMenu()
        {
            var allItemsInMenu = _outingRepository.GetOutingMenu();
            foreach (var menu in allItemsInMenu)
            {
                Console.WriteLine($" {menu.OutingType}, {menu.OutingDate}, {menu.TotalPeople}, {menu.CostPerPerson}, {menu.TotalCost}");

            }
            Console.ReadLine();

        }
        private void CostByType()
        {
            var outingCost = _outingRepository.
        }
        
    }
     
}

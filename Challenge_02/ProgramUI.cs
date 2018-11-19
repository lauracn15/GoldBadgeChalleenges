using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    public class ProgramUI
    {
        ClaimMenu _newClaimMenu = new ClaimMenu();
        ClaimRepository _claimRepository = new ClaimRepository();

        List<ClaimMenu> _claimItems;

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to Komodo Insurance! What would you like to do?" +
                    "\n1. Enter a new claim" +
                    "\n2. Take care of next claim" +
                    "\n3. Review claims");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        CreateNewClaim();
                        Console.ReadKey();
                        break;
                    case 2:
                        GetClaimMenu();
                        Console.ReadKey();
                        break;                
                }
            }
        }
            private void CreateNewClaim()
            {
                ClaimMenu newItem = new ClaimMenu();
                Console.WriteLine("What type of claim do you want to make? Car, home, or theft?");
                newItem.TypeId = Console.ReadLine();

                Console.WriteLine("Give a brief description");
                newItem.Description = Console.ReadLine();

                Console.WriteLine("How much did it cost?");
                newItem.CostOfClaim = int.Parse(Console.ReadLine());

                Console.WriteLine("When did this happen?");
                newItem.DateOfAccident = int.Parse(Console.ReadLine());

                Console.WriteLine("How many days ago did you make the claim?");
                newItem.DateOfClaim = int.Parse(Console.ReadLine());

                int days = (newItem.DateOfClaim - newItem.DateOfAccident);
                if (days >= 0 && days <= 30)
                {
                    newItem.IsValid = true;
                }
            _claimRepository.CreateNewClaim(newItem);
            }
            private void GetClaimMenu()
            {
                var allItemsInMenu = _claimRepository.GetClaimMenu();
                foreach (var menu in allItemsInMenu)
                {
                    Console.WriteLine($" {menu.TypeId} + {menu.Description} + {menu.CostOfClaim} + {menu.DateOfAccident} + {menu.DateOfClaim} ");
                }
               
            }
        
        
    }
}

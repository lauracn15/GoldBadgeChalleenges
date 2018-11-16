using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    class Program
    {
        ClaimMenu _newClaimMenu = new ClaimMenu();
        ClaimRepository _claimRepository = new ClaimRepository();

        List<ClaimMenu> _claimItems;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Komodo Insurance! What would you like to do?" +
                "/n1. See all claims" +
                "/n2. Take care of next claim" +
                "/n3. Enter a new claim");

            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1: SeeAllClaims();
                    break;

                case 2: RemoveClaim();
                    break;

                case 3: CreateNewClaim();
                    Console.ReadKey();
                    break;
            }
        }

        private void SeeAllClaims()
        {

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

            Console.WriteLine("When did you make your claim?");
            newItem.DateOfClaim = int.Parse(Console.ReadLine());
        }
        private void SeeAllClaims()
        {
            var allItemsInMenu = _claimRepository.GetAllMenu();
            foreach (var menu in allItemsInMenu)
            {
                Console.WriteLine($" {menu.TypeId} + {menu.Description} + {menu.CostOfClaim} + {menu.DateOfAccident} + {menu.DateOfClaim} ");
            }
        }

    }
}

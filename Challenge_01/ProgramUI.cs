using System;
using System.Collections.Generic;

namespace Challenge_01
{

    class ProgramUI
    {
        KomodoMenu newKomodoMenu = new KomodoMenu();
        MenuRepo _menuRepo = new MenuRepo();

        List<KomodoMenu>  _komodoItems;
        private int input;

        public void Run()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to Komodo, choose an action" +
                    "\n1. Create menu" +
                    "\n2. See Menu" +
                    "\n3. Remove an item" +
                    "\n4. Exit");

                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1: AddItemToMenu();
                        Console.ReadKey();
                        break;
                    case 2:
                        SeeMenu();
                        Console.ReadKey();
                        break;
                    case 3:RemoveMenuItem();
                        Console.ReadKey();
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Thank you come again");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invalid Response");
                        Console.ReadLine();
                        break;
                }
            }
        }
        private void AddItemToMenu()
        {
            KomodoMenu newItem = new KomodoMenu();

            Console.Clear();       
            Console.WriteLine("Enter the name");
            newItem.Name = Console.ReadLine();

            Console.WriteLine("Give a brief description");
            newItem.Description = Console.ReadLine();

            Console.WriteLine("what are the ingredients?");
            newItem.Ingredients = Console.ReadLine();

            Console.WriteLine("what is the price?");
            newItem.Price = int.Parse(Console.ReadLine());

            _menuRepo.AddItemToMenu(newItem);
        }

        private void SeeMenu()
        {
            List<KomodoMenu> allItemsInMenu = _menuRepo.GetAllMenu();
            foreach (KomodoMenu menu in allItemsInMenu)
            {
                Console.WriteLine($" {menu.Name}  {menu.Ingredients}  {menu.Price} ");
                Console.ReadLine();
            }
        }

        private void RemoveMenuItem()
        {
            Console.WriteLine("Which menu item would you like to remove?");
            int removeNumber = int.Parse(Console.ReadLine());
            foreach (KomodoMenu menu in _komodoItems)
            {
                if (menu.FoodNumber == removeNumber)
                {
                    _menuRepo.RemoveMenuItem(menu);
                    break;
                }


            }
        }
    }
}

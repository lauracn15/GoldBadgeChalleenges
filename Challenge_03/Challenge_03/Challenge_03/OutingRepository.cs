using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    class OutingRepository
    {
        public List<OutingMenu> _menuItem = new List<OutingMenu>();

        public void AddOuting(OutingMenu newMenuItem)
        {
            _menuItem.Add(newMenuItem);
        }


        public List<OutingMenu> GetOutingMenu()
        {
            return _menuItem;
        }

        public List<OutingMenu> CostByType()
        {
            Console.WriteLine($" {_menuItem.CostPerPerson * _menuItem.TotalPeople});
        }
    }
}

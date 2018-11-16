using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_01
{
    class MenuRepo
    {
        public List<KomodoMenu> _menuItem = new List<KomodoMenu>();

        public void AddItemToMenu(KomodoMenu newMenuItem)
        {
            _menuItem.Add(newMenuItem);
        }

        public void RemoveMenuItem(KomodoMenu delete)
        {
            _menuItem.Remove(delete);
        }
        public List<KomodoMenu> GetAllMenu()
        { 
            return _menuItem;
        }

        
    }
}


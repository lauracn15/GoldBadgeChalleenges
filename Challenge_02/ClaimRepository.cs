using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    class ClaimRepository
    {
        public List<ClaimMenu> _menuItem = new List<ClaimMenu>();
         
        public void CreateNewClaim(ClaimMenu newMenuItem)
        {
            _menuItem.Add(newMenuItem);
        }       

        public List<ClaimMenu> GetClaimMenu()
        {
            return _menuItem;
        }
    }
}

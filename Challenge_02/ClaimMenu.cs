using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_02
{
    class ClaimMenu
    {
        public string TypeId { get; set; }
        public string Description { get; set; }
        public decimal CostOfClaim { get; set; }
        public int DateOfAccident { get; set; }
        public int DateOfClaim { get; set; }
        public bool IsValid { get; set; }

        public ClaimMenu(string typeId, string description, decimal costOfClaim, int dateOfAccident, int dateOfClaim, bool isValid )
        {
            TypeId = typeId;
            Description = description;
            CostOfClaim = costOfClaim;
            DateOfAccident = dateOfAccident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }

        public ClaimMenu()
        {

        }
    }
}

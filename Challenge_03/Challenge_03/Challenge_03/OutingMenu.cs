using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_03
{
    class OutingMenu
    {
        public string OutingType { get; set; }
        public string OutingDate { get; set; }
        public int TotalPeople { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalCost { get; set; }


        public OutingMenu(string outingType, string outingDate, int totalPeople, decimal costPerPerson, decimal totalCost)
        {
            OutingType = outingType;
            OutingDate = outingDate;
            TotalPeople = totalPeople;
            CostPerPerson = costPerPerson;
            TotalCost = totalCost;
        }

        public OutingMenu()
        {

        }

    }
    
}

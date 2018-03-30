using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingOrganizerCalculatorWithInheritanceFunction
{
    public class Party
        //We gonna use all of it in our next subclasses
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        virtual public  decimal Cost //We set's this field as virtual because later we gonna override it, at least part of it.
        {
            get
            {
                decimal totalcost = CalculateCostOfDecorations();
                totalcost += (NumberOfPeople * CostOfFoodPerPerson);
                if (NumberOfPeople > 12)
                    return totalcost + 100;
                else
                    return totalcost;
            }
        }
        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15M) + 50;
                return costOfDecorations;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.5M) + 30;
                return costOfDecorations;
            }
        }
    }
}

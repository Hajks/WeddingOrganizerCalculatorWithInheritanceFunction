using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeddingOrganizerCalculatorWithInheritanceFunction
{
    public class DinnerParty : Party
        //Now we have to create all methods and fields which aren't inside base class.
    {
        public bool HealthyOption { get; set; }



        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOption = healthyOption;
            FancyDecorations = fancyDecorations;
        }
        private decimal CalculateCostOfBeveragesPerPerson() 
        {
            int costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = NumberOfPeople * 5;
                return costOfBeveragesPerPerson;
            }
            else
            {
                costOfBeveragesPerPerson = NumberOfPeople * 20;
                return costOfBeveragesPerPerson;
            }            
        }
        override public  decimal Cost //now we gonna expand our cost field from base class.
        { 
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveragesPerPerson();
                if (HealthyOption)
                    return totalCost * 0.95M;
                else
                    return totalCost;                
           }       
        }          
    }
}

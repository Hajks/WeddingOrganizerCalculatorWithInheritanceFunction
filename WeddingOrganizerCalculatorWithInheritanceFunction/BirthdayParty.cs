using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WeddingOrganizerCalculatorWithInheritanceFunction

{
    public class BirthdayParty : Party
    //Now we have to create all methods and fields which aren't inside base class.
    {

        public string CakeWritting { get; set; }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWritting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWritting = cakeWritting;
        }
        private int ActualLenght
        {
            get
            {
                if (CakeWritting.Length > MaxWrittingLength())
                    return MaxWrittingLength();
                else
                    return CakeWritting.Length;
            }
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 20;
            else
                return 40;
        }
        private int MaxWrittingLength()
        {
            if (CakeSize() == 20)
                return 16;
            else
                return 40;
        }
        public bool CakeWrittingTooLong
        {
            get
            {
                if (CakeWritting.Length > MaxWrittingLength())
                    return true;
                else
                    return false;
            }
        }
        override public  decimal Cost //we gonna expand our cost field from base class.
        {
            get
            {
               decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == 20)
                    cakeCost = 40M + ActualLenght * .25M;
                else
                    cakeCost = 75M + ActualLenght * .25M;
                return totalCost + cakeCost;
            }
                                                                 
        }
    }
}
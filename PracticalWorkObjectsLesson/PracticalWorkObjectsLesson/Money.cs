using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalWorkObjectsLesson
{
    public class Money
    {
        private int denominationBill;
        private int numberOfBills;

        public Money(int denominationBill, int numberOfBills)
        {
            this.denominationBill = denominationBill;
            this.numberOfBills = numberOfBills;
        }
        public void PrintMoneyInfo()
        {
            Console.WriteLine($"Номинал купюры = {denominationBill}");
            Console.WriteLine($"Количество купюо = {numberOfBills}");
        } 
        public bool IsEnough( int price)
        {
            return (denominationBill * numberOfBills > price);
        }
        public int GetNumberOfProducts(int price)
        {
            return (int)((denominationBill * numberOfBills) / price);
        }
        public int DenominationBill
        {
            get { return denominationBill; }
            set { denominationBill = value; }
        }
        public int NumberOfBills
        {
            get { return numberOfBills; }
            set { numberOfBills = value; }
        }
        public int AmountOfMoney
        {
            get { return denominationBill * numberOfBills; }
        }

    }
}

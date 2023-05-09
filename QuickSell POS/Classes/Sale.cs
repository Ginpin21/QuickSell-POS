using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSell_POS.Classes
{
    public class Sale
    {
        private int saleID;
        private Employee saleCashier;
        private double saleAmount;
        private DateTime saleDateTime;
        private bool paymentRecieved;
        private int discountPercent;
        private ArrayList saleItems;

        public int SaleID
        {
            get { return saleID; }
            set { saleID = value; }
        }

        public double SaleAmount
        {
            get { return saleAmount; }
            set { saleAmount = value; }
        }

        public DateTime SaleDateTime
        {
            get { return saleDateTime; }
            set { saleDateTime = value; }
        }
        
        public bool PaymentRecieved
        {
            get { return paymentRecieved;}
            set { paymentRecieved = value;}
        }

        public int DiscountPercent 
        {
            get { return discountPercent;}
            set { discountPercent = value; }
        }
        public Employee SaleCashier 
        {
            get { return saleCashier;}
            set { saleCashier = value; }
        }
        public ArrayList SaleItems
        {
            get { return saleItems; }
            set { saleItems = value; }
        }
        public Sale()
        {
            saleID = 0;
            saleAmount = 0;
            saleDateTime = new DateTime();
            saleItems = new ArrayList{ };
            saleCashier = new Employee();
            paymentRecieved = false;
            discountPercent = 0;

        }
        public Sale(int id,double amount, Employee cashier,DateTime dateTime, bool payment,int discount,ArrayList itemList)
        {
            saleID = id;
            saleAmount = amount;
            saleDateTime = dateTime;
            saleItems = itemList;
            saleCashier = cashier;
            paymentRecieved = payment;
            discountPercent = discount;

        }
    }
}

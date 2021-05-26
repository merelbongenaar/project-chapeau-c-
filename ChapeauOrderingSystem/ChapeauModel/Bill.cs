using System;
using System.Collections.Generic;
using System.Text;

namespace ChapeauModel
{
    public enum typeOfPayment { creditCard = 1, pin, cash }
    public class Bill
    {
        public int OrderID { get; set; }
        public double TotalPrice { get; set; }
        public double Tip { get; set; }
        public double Tax { get; set; }
        public typeOfPayment TypeOfPayment { get; set; }
        public string Feedback { get; set; }
    }
}

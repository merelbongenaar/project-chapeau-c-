namespace ChapeauModel
{
    public enum typeOfPayment { creditCard = 1, pin, cash }
    public class Bill
    {
        public int OrderID { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Tip { get; set; }
        public decimal Tax { get; set; }
        public typeOfPayment TypeOfPayment { get; set; }
        public string Feedback { get; set; }
    }
}

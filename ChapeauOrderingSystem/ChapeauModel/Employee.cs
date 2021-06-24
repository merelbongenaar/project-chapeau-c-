namespace ChapeauModel
{
    public enum Role
    {
        Bar = 1, Kitchen, Waiter, Manager
    }

    public class Employee
    {

        public int EmployeeID { get; set; }

        public string Name { get; set; }

        public Role Role { get; set; }

        public string Password { get; set; }
    }
}

namespace G_NET106_OOP_Assignment01
{
    internal class Program
    {
        public struct DeliveryAddress
        {
            public string City; public string Street;
        }

        public class Customer
        {
            public string Name;
        }

        static void Main(string[] args)
        {
            #region Question1A
            //a)What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?

            //the delevery address is struct so the copy we modifying does not affect the original
            #endregion
            #region Question1B
            //b) What happens when a Customer variable is copied into another variable and one variable modifies the object

            //the customer is class so when the copy modified it will make change in the other variable 
            #endregion

        }
    }
}

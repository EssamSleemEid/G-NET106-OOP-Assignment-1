namespace G_NET106_OOP_Assignment01
{
    internal class Program
    {
        public struct DeliveryAddress
        {
            public string City;
            public string Street;

        }

        public class Customer
        {
            public string Name;
        }

        public struct Shipment
        {
            public string Description;
            public double Weight;
            public decimal DeliveryFee;
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

            #region Question2A
            //a)a) Identify at least three problems with this design from an encapsulation perspective.

            //1-the design does not follow proper encapsulation
            //2-all field are public which mean that anyone can modify them
            //3-no validation for the delivery address
            #endregion

            #region Question2B
            //b)b) How can private fields and public properties improve this design?

            //its allow us to control the data what we want to see and what that we don't and modify and add validation when we need
            #endregion
        }
    }
}

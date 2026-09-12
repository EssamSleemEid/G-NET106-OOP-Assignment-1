namespace G_NET106_OOP_Assignment01
{
    internal class Program
    {
        public struct DeliveryAddress
        {
            public string City;
            public string Street;
            public int BuldingNumber;
            public DeliveryAddress(string city, string street, int buldingNumber)
            {
                City=city;
                Street=street;
                BuldingNumber=buldingNumber;
            }
            public string GetFullAddress()
            {
                return $"bulding number : {BuldingNumber}, street : {Street}, city : {City}";
            }
        }

        public class Customer
        {
            public string Name;
        }

        public struct Shipment
        {
            private string description;
            private double weight;
            private decimal deliveryFee;
            private string trackingCode;
            public DeliveryAddress Destination {  get; set; }
            public string TrackingCode {
                get { return trackingCode; }
            }
            public string Description { 
                get { return description;}

                set {
                    if (value!=null){
                        description = value;} 
                }
            }
            public double Weight
            {
                get { return weight; }

                set {
                    if(value > 0){
                        weight = value;
                    }
                }
            }
            public decimal DeliveryFee
            {
                get{ return deliveryFee; }

                set {

                    if (value > 0) { 
                        deliveryFee = value; }
                }
            }
            public decimal EstimatedCost {
                get { return DeliveryFee + (decimal)(Weight * 5); }
            }
            public Shipment(string trackingCode)
            {
                this.trackingCode = trackingCode==null ? "unknown" : trackingCode;

                description = "unknown";
                weight = 1;
                deliveryFee = 50;
                Destination = new DeliveryAddress("Cairo", "Unknown Street", 0);
            }
            public Shipment(string trackingCode,string description,double weight,decimal deliveryFee,DeliveryAddress destination)
            {
                this.trackingCode = trackingCode == null ? "Unknown": trackingCode;
                this.description = description == null ? "Unknown" : description;
                this.weight = weight > 0 ? weight : 1;
                this.deliveryFee = deliveryFee > 0 ? deliveryFee : 50;
                Destination = destination;
            }
            public void UpdateDeliveryFee(decimal newFee)
            {
                if (newFee > 0)
                {
                    deliveryFee = newFee;
                }
            }
            public void PrintShipment()
            {
                Console.WriteLine("trackingCode : "+ TrackingCode);
                Console.WriteLine("description : " + Description);
                Console.WriteLine("weight : " + Weight+" kg");
                Console.WriteLine("deliveryFee : " + DeliveryFee);
                Console.WriteLine("Destination : " + Destination.GetFullAddress());
                Console.WriteLine("estimatedCost : " + EstimatedCost+" egy");
            }
        }

        static void Main(string[] args)
        {
            #region Part1

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

            #endregion

            #region Part2

            #endregion
        }
    }
}

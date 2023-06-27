namespace FacadeSample
{

    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. 
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place order started");

            // Get the product details
            Product product = new Product();
            product.GetProductDetails();

            // Add product to the shopping cart
            Cart cart = new Cart();
            cart.AddToCart();

            // Make payment 
            Payment payment = new Payment();
            payment.MakePayment();

            // Ship product
            Shipping shipping = new Shipping();
            shipping.Ship();

        }

    }
}
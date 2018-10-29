namespace NewAssembly
{
    // The syntax ChildCustomer: Customer implies that the class ChildCustomer inherits all of the methods from the class customer
    public class ChildCustomer : Customer
    {
        public void TestChild()
        { 
            this.PromoteOnce();
            // this.PromoteTwice(); // this is still not accessible since it is private
            this.PromoteThrice(); // this is now accessible since this class inherits its methods from the Customers class
        }
    }
}

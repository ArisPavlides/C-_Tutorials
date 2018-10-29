using AccessModifiers_Advanced;

namespace NewAssembly
{
    class MethodsInNewAssembly
    {
        public void NewMethods()
        {
            var customer = new Customer();
            var child = new ChildCustomer();
            // var offer = new Offers(); // this class is not accessible since it is declared internal and lies in a different assembly
        }
    }
}

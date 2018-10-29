using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace NewAssembly
{
    /*
     * If the access modifier is set to public, the class or methods will be accessible from everywhere in the program. This is 
     * needed because the classes/methods/variables may provide functionality that needs to be accessed from everywhere. 
     * 
     * The private access modifier will hide the classes/methods/variables since they contain implementation details which, following 
     * the principles of Object-Oriented Programming, should be hidden and not accessible from everyone in order to increase stability. 
     * 
     * The protected access modifier means that the classes/methods/variablesare accessible only from the class itself and its derived 
     * classes. Use this access modifier with caution since they expose the implemenation details of one class to another class, creating
     * interdependencies which may cause the code to break if the classes/methods/variables from the parent class are altered.
     */
    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void PromoteOnce() { }

        private void PromoteTwice() { }

        protected void PromoteThrice() { }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Person
    {
        // even though in "Access Modifiers" we state that declaring a field as public goes against
        // the concept of encapsulation, the field below is interpreted by C# as private and the get; set;
        // properties serve the purpose of Get_ and Set_ methods shown in "Access Modifiers"
            
        // the se method is set as private (i.e. is readonly) since we can set it in the beginning and never be able 
        // to access it again in order to modify it. Therefore, in order to set its initial value, we create the 
        // constructor below
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthDate)
        {
            this.Birthdate = birthDate;
        }

        public int Age
        {
            get
            {
                TimeSpan span = DateTime.Now - Birthdate;
                return span.Days / 365;
            }

            // a set method is not given since an age can only be calculated in this context; not set
        }
    }
}

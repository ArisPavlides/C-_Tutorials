using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Person
    {
        // when declaring fields, the common convension is to start the name of the field with an underscore
        private DateTime _birthDate; // this means that we cannot access the field outside the Person class

        // THE GET SET METHODS SHOWN BELOW ARE NOT THE CLEANEST WAY IF ASSIGNING VALUES TO VARIABLES
        // IN ANOTHER CLASS. FOR MORE INFO CHECK THE FOLDER "PROPERTIES"

        // since we cannot access the _birthDate field outside the Person class, we must create a method which 
        // will be accessible outside the class and will assign a value to the _birthDate field
        public void SetBirthdate(DateTime birthDate)
        {
            this._birthDate = birthDate;
        }

        // this return method completes the function of the above function by returning the value set for the field
        public DateTime GetBirthDate()
        {
            return this._birthDate;                
        }
    }
}

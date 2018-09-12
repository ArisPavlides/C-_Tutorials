using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    // an enum contains by default variables of type integer. Enums are basically a set of named constants
    public enum TrainTypes
    {
        // if we dont set the values of the variables to anything, by default the first variable will take a 
        // value of zero and the rest will be incremented by one 
        CrossCountryService = 375,
        IntercityService = 140,
        LocalService = 242
    }

    class Program
    {
        static void Main()
        {
            // calling the enum class like this, will only return the name of the variable formatted as an Enum type
            Enum train_type = TrainTypes.CrossCountryService;
            Console.WriteLine(train_type);

            // if we want to return the integer assigned to the variable, we need to cast it as string
            int train_idx = (int)TrainTypes.CrossCountryService;
            Console.WriteLine(train_idx);

            // this returns the variable name with the index stated formatted as an Enum type
            int train_req = 375;
            Enum train_type_alt = (TrainTypes)train_req;
            Console.WriteLine(train_type_alt);

            // convert the enum variable to a string. we cannot cast it since they are not primitives 
            string train_type_str = train_type_alt.ToString();
            Console.WriteLine(train_type_str);

            // convert a string into an enum type
            string choose_service = "IntercityService";
            TrainTypes enum_service = (TrainTypes)Enum.Parse(typeof(TrainTypes), choose_service);
            Console.ReadLine();
        }
    }
}

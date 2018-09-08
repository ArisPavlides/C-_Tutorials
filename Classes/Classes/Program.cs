using System;
using Classes.Maths;

namespace Classes
{    
    class Program
    {
        static void Main()
        {
            // User_Name class is NOT a static class so we must instantiate it before calling any methods that belong to it
            // If the class is NOT static, by calling the new operator we are allocating a location in memory where the new 
            // class can be found. The good thing is that after we are done working with the class instance, c# gargabge collector
            // removes the class instance from memory
            User_Name user_1 = new User_Name();
            user_1.FirstName = "Aris";
            user_1.LastName = "Pavlides";
            user_1.Introduce();

            // Calculator class is static so we can call any methods directly without instantiating first
            // Static classes can only be found in one place in the memory so the computer always uses the same instance
            // Static classes contain static objects that can't be instantiated multiple times. Usually static classes 
            // are used to house static methods that provide calculations, general processing patterns, string output 
            // formats, etc. Static classes are light weight and don't need instantiation.
            int sum = Calculator.Addition(3, 5);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}

using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            var dog = new Animal();

            // Create a class Animal [DONE]
            // give this class 4 members that all Animals have in common [DONE]


            // Create a class Bird [DONE]
            // give this class 4 members that are specific to Bird [DONE]
            // Set this class to inherit from your Animal Class [DONE]

            // Create a class Reptile [DONE]
            // give this class 4 members that are specific to Reptile [DONE]
            // Set this class to inherit from your Animal Class [DONE]




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var pigeon = new Bird()
            {
                FeatherColor = "White",
                Wings = 2,
                IsWarmBlooded = true,
                CanFly = true,
            };

            var beardedDragon = new Reptile()
            {
                ScaleColor = "Yellow",
                ClawLength = "Short",
                TailLengthInches = 6,
                ColorChanges = true,
            };

            pigeon.ShowDetails();

            Console.WriteLine("\n");

            beardedDragon.ShowDetails();
        }
    }
}

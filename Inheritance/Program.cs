using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird = new Bird
            {
                Name = "Eagle",
                Age = 5,
                Habitat = "Mountains",
                IsPredator = true,
                FeatherColor = "Brown",
                CanFly = true,
                Wingspan = 6,
                HasBeak = true
            };
            Console.WriteLine($"Bird Information:");
            Console.WriteLine($"This bird is an {bird.Name} and is {bird.Age} years old. It can be found in {bird.Habitat}. It is {(bird.IsPredator ? "a predator" : "not a predator")}.");
            Console.WriteLine($"Its feathers are {bird.FeatherColor}, and it {(bird.CanFly ? "can" : "cannot")} fly. Its wingspan is {bird.Wingspan} inches, and it {(bird.HasBeak ? "has" : "does not have")} a beak.");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile reptile = new Reptile
            {
                Name = "Crocodile",
                Age = 10,
                Habitat = "Swamps and Rivers",
                IsPredator = true,
                IsColdBlooded = true,
                HasScales = true,
                CanRegenerate = false,
                LaysEggs = true
            };
            Console.WriteLine("\nReptile Information:");
            Console.WriteLine($"This reptile is a {reptile.Name} and is {reptile.Age} years old. It typically inhabits {reptile.Habitat} and it is {(reptile.IsPredator ? "an apex predator" : "not a predator")}, and it is {(reptile.IsColdBlooded ? "cold-blooded" : "warm-blooded")}. It {(reptile.HasScales ? "has" : "does not have")} scales.");
            Console.WriteLine($"It can {(reptile.CanRegenerate ? "regenerate" : "not regenerate")} and {(reptile.LaysEggs ? "lays eggs" : "gives live birth")}.");
        }
    }
}

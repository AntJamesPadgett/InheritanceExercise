using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // DONE- Be sure to follow best practice when creating your classes

            // DONE-Create a class Animal
            // DONE-give this class 4 members that all Animals have in common


            //DONE- Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // DONE- Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();
            myBird.WingColor = "blue";
            myBird.CanFly = true;
            myBird.BeakLength = 3.5;
            myBird.WillMigrate = true;

            var lizard = new Reptile()
            {
                IsColdBlooded = true,
                IsScaly = true,
                Habitat = "swamp",
                CanGrowTail = true,
            
            };
            var myAnimals = new Animal[] { myBird, lizard };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It has:{animal.LegCount} legs");
                Console.WriteLine($"It lives by:{animal.LandSeaAir}");
            }

           

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}

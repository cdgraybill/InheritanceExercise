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
            // Set this class to inherit from your Animal class


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird Pelican = new Bird(2, true, 7, false);

            Console.WriteLine("Pelican Attributes");

            Console.WriteLine(Pelican.NumberOfLegs);
            Console.WriteLine(Pelican.HasTail);
            Console.WriteLine(Pelican.Age);
            Console.WriteLine(Pelican.HasHair);

            Console.ReadLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird Frog = new Bird(4, false, 87997898, false);

            Console.WriteLine("Frog Attributes");

            Console.WriteLine(Pelican.NumberOfLegs);
            Console.WriteLine(Pelican.HasTail);
            Console.WriteLine(Pelican.Age);
            Console.WriteLine(Pelican.HasHair);

            Console.ReadLine();
        }
    }
}

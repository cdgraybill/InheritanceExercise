using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool HasTail { get; set; }
        public int Age { get; set; }
        public bool HasHair { get; set; }
    }

    class Bird : Animal
    {
        public Bird(int legs, bool tail, int age, bool hair)
        {
            NumberOfLegs = legs;
            HasTail = tail;
            Age = age;
            HasHair = hair;
        }
    }

    class Reptile : Animal
    {
        public Reptile(int legs, bool tail, int age, bool hair)
        {
            NumberOfLegs = legs;
            HasTail = tail;
            Age = age;
            HasHair = hair;
        }
    }
}

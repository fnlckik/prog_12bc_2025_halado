using System;

namespace _4_Animals
{
    internal class Cat : Animal
    {
        public string color;

        public Cat(string name, int age, string color) : base(name, age)
        {
            this.color = color;
            this.species = "Emlős";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.name}: Miau!");
        }
    }
}

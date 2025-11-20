using System;

namespace _4_Animals
{
    internal class Bird : Animal
    {
        public bool canFly;
        public string sound;

        public Bird(string name, int age, bool canFly, string sound) : base(name, age)
        {
            this.canFly = canFly;
            this.sound = sound;
            this.species = "Szárnyas";
        }

        public override string ToString()
        {
            string fly = this.canFly ? "repül" : "nem repül";
            return base.ToString() + $" [{fly}]";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.name}: {this.sound}!");
        }
    }
}

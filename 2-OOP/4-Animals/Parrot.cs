using System;

namespace _4_Animals
{
    internal class Parrot : Bird
    {
        public string color;

        public Parrot(string name, int age, string sound, string color)
               : base(name, age, true, sound)
        {
            this.color = color;
        }

        public void Repeat(string text)
        {
            Console.WriteLine($"{this.name}: {text}");
        }
    }
}

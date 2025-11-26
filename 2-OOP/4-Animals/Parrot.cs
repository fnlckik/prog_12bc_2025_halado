using System;

namespace _4_Animals
{
    internal class Parrot : Bird, ITrickPerformer
    {
        private string color;

        public Parrot(string name, int age, string sound, string color)
               : base(name, age, true, sound)
        {
            this.color = color;
        }

        public void PerformTrick()
        {
            Console.WriteLine($"{this.name} viccet mesél.");
        }

        public void Repeat(string text)
        {
            Console.WriteLine($"{this.name}: {text}");
        }
    }
}

using System;

namespace _4_Animals
{
    // sealed: nem lehet származtatni az osztályból
    internal /*sealed*/ class Cat : Animal
    {
        public string color;

        public Cat(string name, int age, string color) : base(name, age)
        {
            this.color = color;
            this.species = "Emlős";
        }

        // polimorfizmus: többalakúság
        // Ugyanaz a metódus különböző alosztályokban
        // más implementációval (törzzsel) rendelkezik.
        public override void MakeSound()
        {
            Console.WriteLine($"{this.name}: Miau!");
        }

        // sealed: lezárt, nem lehet override-olni alosztályban
        public sealed override void Sleep()
        {
            Console.WriteLine($"{this.name} alszik a billentyűzeten.");
        }
    }
}

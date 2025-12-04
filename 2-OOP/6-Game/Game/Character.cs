using System;

namespace Game
{
    internal abstract class Character : IComparable<Character>
    {
        private string name;
        protected int damage;
        protected int health;

        public Character(string name, int damage, int health)
        {
            this.name = name;
            this.damage = damage;
            this.health = health;
        }

        public virtual void TakeDamage(int amount)
        {
            health -= amount;
            if (health < 0) health = 0;
        }

        public bool IsDead()
        {
            return health == 0;
        }

        public override string ToString()
        {
            return $"{name} (DMG: {damage} HP: {health})";
        }

        public int CompareTo(Character other)
        {
            int power = this.damage * this.health;
            int otherPower = other.damage * other.health;
            if (power < otherPower) return -1;
            else if (power > otherPower) return 1;
            else return 0;
        }
    }
}

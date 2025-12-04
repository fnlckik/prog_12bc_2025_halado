using System;

namespace Game
{
    internal sealed class Hero : Character, IAttacker
    {
        public Hero(string name, int damage, int health)
               : base(name, damage, health)
        {
        }

        public void Attack(Character target)
        {
            target.TakeDamage(damage);
        }

        public void Heal()
        {
            health = (int)Math.Round(health * 1.2);
        }
    }
}

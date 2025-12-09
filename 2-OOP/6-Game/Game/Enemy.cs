using System;

namespace Game
{
    internal abstract class Enemy : Character, IAttacker
    {
        public Enemy(string name, int damage, int health)
               : base(name, damage, health)
        {
        }

        public abstract void Attack(Character target);
    }
}

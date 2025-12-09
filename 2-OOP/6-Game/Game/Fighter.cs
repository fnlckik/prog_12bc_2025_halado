namespace Game
{
    internal class Fighter : Enemy
    {
        public Fighter(string name, int damage, int health)
               : base(name, damage, health)
        {
        }

        public override void Attack(Character target)
        {
            target.TakeDamage(damage);
        }

        public override void TakeDamage(int amount)
        {
            int defence = Rng.Randint(0, 10);
            if (amount > defence)
            {
                health = health - (amount - defence);
                if (health < 0) health = 0;
            }
        }

        public override string ToString()
        {
            return "[Fighter]:: " + base.ToString();
        }
    }
}

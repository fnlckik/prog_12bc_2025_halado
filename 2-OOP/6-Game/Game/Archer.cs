namespace Game
{
    internal class Archer : Enemy
    {
        private bool fast;

        public Archer(string name, int damage, int health, bool fast)
               : base(name, damage, health)
        {
            this.fast = fast;
        }

        public override void Attack(Character target)
        {
            target.TakeDamage(damage);
            if (fast)
            {
                target.TakeDamage(damage);
                target.TakeDamage(damage);
            }
        }

        public override string ToString()
        {
            return "[Archer]:: " + base.ToString();
        }
    }
}

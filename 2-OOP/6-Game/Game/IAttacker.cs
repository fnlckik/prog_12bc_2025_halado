namespace Game
{
    internal interface IAttacker
    {
        void Attack(Character target);
        void TakeDamage(int amount);
        bool IsDead();
    }
}

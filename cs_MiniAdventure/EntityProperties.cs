namespace cs_MiniAdventure
{
    public abstract class EntityProperties
    {
        public string Name { get; private set; }
        public int HP { get; set; }
        public int MaxHp { get; private set; }
        public int Damage { get; private set; }

        public EntityProperties(string name, int hp, int damage)
        {
            Name = name;
            HP = hp;
            MaxHp = hp;
            Damage = damage;
        }

        public abstract void Attack(EntityProperties target);

        public void TakeDamage(int damage)
        {
            HP -= damage;
            if (HP < 0) HP = 0;
        }
    }
}

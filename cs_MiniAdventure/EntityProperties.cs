namespace cs_MiniAdventure
{
    public abstract class EntityProperties
    {
        //Properties
        public string Name { get; private set; }
        public int HP { get; private set; }
        public int Damage { get; private set; }

        //Constructor
        public EntityProperties(string name, int hp, int damage)
        {
            Name = name;
            HP = hp;
            Damage = damage;
        }

        public abstract void Attack();



    }
}

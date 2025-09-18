namespace cs_MiniAdventure.Heros
{
    public abstract class Hero : EntityProperties
    {
        //Properties
        public int Mana { get; private set; }

        //Constructor
        public Hero(string name, int hp, int damage, int mana) : base(name, hp, damage)
        {
            Mana = mana;
        }
    }
}

namespace cs_MiniAdventure.Heros
{
    public abstract class Hero : EntityProperties
    {
        //Properties
        public int Mana { get; private set; }
        public int Gold { get; set; }

        //Constructor
        public Hero(string name, int hp, int damage, int mana, int gold) : base(name, hp, damage)
        {
            Mana = mana;
            Gold = gold;
        }
    }
}

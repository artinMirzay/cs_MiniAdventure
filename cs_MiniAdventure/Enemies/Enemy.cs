namespace cs_MiniAdventure.Enemies
{
    public abstract class Enemy : EntityProperties
    {
        //Properties
        public int GoldDrop { get; private set; }

        //Constructor
        public Enemy(string name, int hp, int damage, int goldDrop) : base(name, hp, damage)
        {
            GoldDrop = goldDrop;
        }

        public int DropGold()
        {
            return GoldDrop;
        }
    }
}

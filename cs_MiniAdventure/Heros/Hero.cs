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

        public void Heal()
        {
            if (Mana >= 10)
            {
                int healAmount = 20;
                HP += healAmount;
                Mana -= 10;
                Console.WriteLine($"{Name} heals for {healAmount} HP! Mana left: {Mana}");
            }
            else
            {
                Console.WriteLine("Not enough Mana to heal!");
            }


        }
    }
}

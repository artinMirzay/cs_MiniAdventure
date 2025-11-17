namespace cs_MiniAdventure.Heros
{
    public abstract class Hero : EntityProperties
    {
        //Properties
        public int Mana { get; private set; }
        public int Gold { get; set; }
        public int Potions { get; set; }

        //Constructor
        public Hero(string name, int hp, int damage, int mana, int gold, int potions) : base(name, hp, damage)
        {
            Mana = mana;
            Gold = gold;
            Potions = potions;
        }

        public void Heal()
        {
            if (Mana >= 10)
            {
                int healAmount = 20;
                int oldHP = HP;
                HP += healAmount;
                if (HP > MaxHp) HP = MaxHp;
                Mana -= 10;
                int actualHeal = HP - oldHP;
                Console.WriteLine($"{Name} heals for {actualHeal} HP! Mana left: {Mana} | Current HP: {HP}/{MaxHp}");
            }
            else
            {
                Console.WriteLine("Not enough Mana to heal!");
            }


        }

        public void UsePotion()
        {
            if (Potions > 0)
            {
                int healAmount = 30;
                int oldHP = HP;
                HP += healAmount;
                if (HP > MaxHp) HP = MaxHp;
                int actualHeal = HP - oldHP;
                Potions--;

                Console.WriteLine($"{Name} uses a potion and heals for {actualHeal} HP! Potions left: {Potions} | Current HP: {HP}/{MaxHp}");
            }
            else
            {
                Console.WriteLine("You have no potions to use!");
            }
        }

    }
}

namespace cs_MiniAdventure.Heros.HeroTypes
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base("Warrior", 100, 15, 50, 0) { }

        public override void Attack(EntityProperties target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {Damage} Damage!");
            target.TakeDamage(Damage);
        }
    }
}

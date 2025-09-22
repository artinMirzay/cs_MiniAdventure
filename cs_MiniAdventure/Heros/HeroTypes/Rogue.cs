namespace cs_MiniAdventure.Heros.HeroTypes
{
    public class Rogue : Hero
    {
        public Rogue(string name) : base("Rogue", 80, 25, 50, 0) { }

        public override void Attack(EntityProperties target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {Damage} Damage!");
            target.TakeDamage(Damage);
        }
    }
}

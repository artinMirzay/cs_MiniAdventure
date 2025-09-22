namespace cs_MiniAdventure.Heros.HeroTypes
{
    public class Mage : Hero
    {
        public Mage(string name) : base("Mage", 90, 30, 100, 0) { }

        public override void Attack(EntityProperties target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {Damage} Damage!");
            target.TakeDamage(Damage);
        }
    }
}

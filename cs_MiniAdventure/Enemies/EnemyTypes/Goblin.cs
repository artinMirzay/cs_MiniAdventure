namespace cs_MiniAdventure.Enemies.EnemyTypes
{
    public class Goblin : Enemy
    {
        public Goblin() : base("Goblin", 100, 5, 1) { }

        public override void Attack(EntityProperties target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {Damage}!");
            target.TakeDamage(Damage);
        }
    }
}

namespace cs_MiniAdventure.Enemies.EnemyTypes
{
    public class Golem : Enemy
    {
        public Golem() : base("Golem", 200, 15, 15) { }

        public override void Attack(EntityProperties target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {Damage}!");
            target.TakeDamage(Damage);
        }
    }
}

namespace cs_MiniAdventure.Enemies.EnemyTypes
{
    public class Wolf : Enemy
    {
        public Wolf() : base("Wolf", 100, 20, 15) { }

        public override void Attack(EntityProperties target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {Damage}!");
            target.TakeDamage(Damage);
        }
    }
}

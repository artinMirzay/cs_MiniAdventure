namespace cs_MiniAdventure.Enemies.EnemyTypes
{
    public class Goblin : Enemy
    {
        public Goblin() : base("Goblin", 100, 5, 1) { }

        public override void Attack()
        {
            Console.WriteLine("Goblin attacks with knife!");
        }
    }
}

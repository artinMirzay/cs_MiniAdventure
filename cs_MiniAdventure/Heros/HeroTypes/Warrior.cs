namespace cs_MiniAdventure.Heros.HeroTypes
{
    public class Warrior : Hero
    {
        public Warrior() : base("Warrior", 100, 15, 50) { }

        public override void Attack()
        {
            Console.WriteLine("Warrior attacks with sword!");
        }
    }
}

namespace cs_MiniAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ClassData[] ClassCatalog = new ClassData[]
            {
                new ClassData { Name = "Warrior", Hp = 200, Damage = 80, Mana = 0 },
                new ClassData { Name = "Mage", Hp = 100, Damage = 100, Mana = 100 }
            };

            Console.WriteLine("=== MINI ADVENTURE ===\n");

            PlayerData player = AdventureHelper.Start();
            AdventureHelper.ChooseClass(player, ClassCatalog);

            Console.WriteLine("Player Stats:");
            Console.WriteLine($"Username: {player.UserName}");
            Console.WriteLine($"Class: {ClassCatalog[player.Class - 1].Name}");


        }
    }
}

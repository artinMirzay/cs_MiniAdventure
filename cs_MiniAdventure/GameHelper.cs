using cs_MiniAdventure.Heros;
using cs_MiniAdventure.Heros.HeroTypes;

namespace cs_MiniAdventure
{
    public static class GameHelper
    {
        public static Hero Player { get; private set; }

        public static void StartGame()
        {
            Console.Clear();
            Console.Write("Enter your player name: ");
            string? playerName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(playerName))
                playerName = "Hero";

            Console.WriteLine("\nChoose your starting class:");
            Console.WriteLine("[1] Warrior");
            Console.WriteLine("Enter number:");

            int choice = MiniHelper.ReadNumber();

            switch (choice)
            {
                case 1:
                    Player = new Warrior(playerName);
                    break;

                default:
                    Console.WriteLine("Invalid choice — Warrior selected by default.");
                    Player = new Warrior(playerName);
                    break;
            }

            Console.WriteLine($"\nWelcome {playerName}, the Warrior!");
            Console.WriteLine($"Starting HP: {Player.HP}/{Player.MaxHp}");
            Console.WriteLine($"Mana: {Player.Mana}, Gold: {Player.Gold}, Potions: {Player.Potions}");
            Console.WriteLine("\nPress any key to begin your adventure...");
            Console.ReadKey();

            for (int level = 1; level <= 3; level++)
            {
                LevelHelper.StartHelper(level, Player);

                if (Player.HP <= 0)
                {
                    Console.WriteLine("Game Over!");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("\nAll enemies defeated!");
            Console.WriteLine($"Final Gold: {Player.Gold}");
            Console.ReadKey();
        }
    }
}

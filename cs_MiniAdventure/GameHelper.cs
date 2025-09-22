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
            Console.Write("Enter Your player name: ");
            string playerName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Choose your starting class: ");
            Console.WriteLine("[1] Warrior");
            Console.WriteLine("[2] Mage");
            Console.WriteLine("[3] Rogue");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Player = new Warrior(playerName);
                    break;
                case 2:
                    Player = new Mage(playerName);
                    break;
                case 3:
                    Player = new Rogue(playerName);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine($"Welcome {playerName}, the {Player.GetType().Name}\nPress Any key to start game");
            Console.WriteLine("==================================");
            Console.ReadKey();
            Console.Clear();

            for (int level = 0; level <= 3; level++)
            {
                LevelHelper.StartHelper(level, Player);

                if (Player.HP <= level)
                {
                    Console.WriteLine("Game Over!");
                    break;
                }
            }

            Console.WriteLine($"Final Gold: {Player.Gold}");
        }
    }
}

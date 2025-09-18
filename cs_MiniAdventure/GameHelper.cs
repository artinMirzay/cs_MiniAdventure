using cs_MiniAdventure.Heros;
using cs_MiniAdventure.Heros.HeroTypes;

namespace cs_MiniAdventure
{
    public static class GameHelper
    {
        public static Hero Player { get; private set; }

        public static void StartGame()
        {
            Console.Write("Enter Your player name:");
            string playerName = Console.ReadLine();

            Console.WriteLine("Choose your starting class: ");
            Console.WriteLine("[1] Warrior");
            Console.WriteLine("[2] Mage");
            Console.WriteLine("[3] Rogue");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Player = new Warrior(playerName);
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Welcome {playerName}, the {Player.GetType().Name}");
        }
    }
}

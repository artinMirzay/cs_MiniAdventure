using cs_MiniAdventure.Enemies;
using cs_MiniAdventure.Enemies.EnemyTypes;
using cs_MiniAdventure.Heros;

namespace cs_MiniAdventure
{
    public static class LevelHelper
    {
        public static void StartHelper(int level, Hero player)
        {
            Console.WriteLine($"--- Level {level} ---");

            Enemy enemy = level switch
            {
                1 => new Goblin(),
                2 => new Wolf(),
                3 => new Golem(),
                _ => new Goblin()
            };

            Console.WriteLine($"A Wild {enemy.Name} appears!");

            while (player.HP > 0 && enemy.HP > 0)
            {
                Console.WriteLine("[1] Attack");
                Console.WriteLine("[2] Heal");
                Console.WriteLine("[3] Run");
                Console.Write("Choose your action: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        player.Attack(enemy);
                        break;
                    case 2:
                        player.Heal();
                        break;
                    case 3:
                        Console.WriteLine("You attempt to run...");
                        bool escaped = TryToRun();
                        if (escaped)
                        {
                            Console.WriteLine("You escaped successfully!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("You failed to escape!");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
                if (enemy.HP > 0)
                {
                    enemy.Attack(player);
                }
            }

            if (player.HP > 0)
            {
                Console.WriteLine("You defeated the enemy!");
                player.Gold += enemy.DropGold();
            }
            else
            {
                Console.WriteLine("You were defeated...");
            }
        }

        public static bool TryToRun()
        {
            Random random = new Random();
            return random.Next(0, 2) == 1; //50%
        }
    }
}

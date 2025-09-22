using cs_MiniAdventure.Enemies;
using cs_MiniAdventure.Enemies.EnemyTypes;
using cs_MiniAdventure.Heros;

namespace cs_MiniAdventure
{
    public static class LevelHelper
    {

        private static Random rng = new Random();
        private static Enemy[] enemies = new Enemy[]
        {
            new Goblin(),
            new Golem(),
            new Wolf()
        };


        public static void StartHelper(int level, Hero player)
        {
            Console.WriteLine($"--- Level {level} ---");

            Enemy enemy = level switch
            {
                1 => new Goblin(),
                2 => GetRandomEnemy(),
                3 => new Golem(),
                _ => GetRandomEnemy()
            };
            Console.Clear();
            Console.WriteLine($"A Wild {enemy.Name} appears!");

            while (player.HP > 0 && enemy.HP > 0)
            {
                Console.WriteLine("===========================");
                Console.WriteLine($"HP: {player.HP}/100 | MANA: {player.Mana}/100");
                Console.WriteLine("===========================");
                Console.WriteLine("[1] Attack");
                Console.WriteLine("[2] Heal");
                Console.WriteLine("[3] Run");
                Console.WriteLine("---------------------------");
                Console.Write("Choose your action: ");

                int choice = int.Parse(Console.ReadLine());
                Console.Clear();

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
                Console.WriteLine("You defeated the enemy!\nPress any key to continue");
                Console.ReadKey();
                player.Gold += enemy.DropGold();
            }
            else
            {
                Console.WriteLine("You were defeated...\nPress any key to continue");
                Console.ReadKey();
            }
        }

        public static bool TryToRun()
        {
            Random random = new Random();
            return random.Next(0, 2) == 1; //50%
        }
        public static Enemy GetRandomEnemy()
        {
            return enemies[rng.Next(enemies.Length)];
        }
    }
}

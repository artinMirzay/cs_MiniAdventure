using cs_MiniAdventure.Enemies;
using cs_MiniAdventure.Enemies.EnemyTypes;
using cs_MiniAdventure.Heros;

namespace cs_MiniAdventure
{
    public static class LevelHelper
    {
        private static Random random = new Random();

        public static void StartHelper(int level, Hero player)
        {
            Console.Clear();
            Console.WriteLine($"--- Level {level} ---\n");

            Enemy enemy = level switch
            {
                1 => new Goblin(),
                2 => new Wolf(),
                3 => new Golem(),
                _ => new Goblin()
            };

            Console.WriteLine($"A wild {enemy.Name} appears!");
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            while (player.HP > 0 && enemy.HP > 0)
            {
                Console.Clear();
                Console.WriteLine($"--- Level {level} ---");
                Console.WriteLine($"{player.Name}: {player.HP}/{player.MaxHp} HP | Mana: {player.Mana} | Potions: {player.Potions}");
                Console.WriteLine($"{enemy.Name}: {enemy.HP} HP\n");

                Console.WriteLine("[1] Attack");
                Console.WriteLine("[2] Heal (Mana)");
                Console.WriteLine("[3] Use Potion");
                Console.WriteLine("[4] Run");
                Console.WriteLine("\nChoose your action:");

                int choice = MiniHelper.ReadNumber();
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
                        player.UsePotion();
                        break;

                    case 4:
                        Console.WriteLine("You attempt to run...");

                        if (TryToRun())
                        {
                            Console.WriteLine("You escaped successfully!");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Console.WriteLine("You failed to escape!");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid action.");
                        break;
                }

                if (enemy.HP > 0)
                    enemy.Attack(player);

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

            if (player.HP > 0)
            {
                Console.Clear();
                Console.WriteLine("You defeated the enemy!");

                int gold = enemy.DropGold();
                player.Gold += gold;

                Console.WriteLine($"You gained {gold} gold! Total gold: {player.Gold}");

                if (random.Next(0, 2) == 1)
                {
                    player.Potions++;
                    Console.WriteLine("The enemy dropped a potion!");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You were defeated...");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        public static bool TryToRun()
        {
            return random.Next(0, 2) == 1;
        }
    }
}

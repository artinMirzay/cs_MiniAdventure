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
                1 => new Goblin()
            };

            Console.WriteLine($"A Wild {enemy.Name} appears!");

            while (player.HP > 0 && enemy.HP > 0)
            {
                player.Attack();
                enemy.Attack();
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


    }
}

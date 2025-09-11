namespace cs_MiniAdventure
{
    public static class AdventureHelper
    {
        public static PlayerData Start()
        {
            PlayerData playerData = new PlayerData();

            Console.Write("Set Username: ");
            playerData.UserName = Console.ReadLine();

            return playerData;
        }

        public static void ChooseClass(PlayerData player, ClassData[] classList)
        {
            Console.WriteLine("=== Class List ===");

            for (int i = 0; i < classList.Length; i++)
            {
                ClassData c = classList[i];
                Console.WriteLine($"[{i + 1}] {c.Name} | HP: {c.Hp} | DMG: {c.Damage} | MANA: {c.Mana}]");
            }

            Console.Write("Choose Class: ");
            int choice = int.Parse(Console.ReadLine());

            ClassData ChosenClass = classList[choice - 1];

            player.Class = choice;
            player.HP = ChosenClass.Hp;
            player.Damage = ChosenClass.Damage;
            player.Gold = 0;
        }
    }
}

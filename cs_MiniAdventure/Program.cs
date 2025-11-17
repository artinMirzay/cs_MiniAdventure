namespace cs_MiniAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                MiniHelper.MainMenu();

                Console.WriteLine("\nChoose an option:");
                int choice = MiniHelper.ReadNumber();

                switch (choice)
                {
                    case 1:
                        GameHelper.StartGame();
                        break;

                    case 2:
                        Console.WriteLine("Options not implemented.");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("Exiting game...");
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Press any key.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

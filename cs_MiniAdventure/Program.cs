namespace cs_MiniAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                MiniHelper.MainMenu();
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GameHelper.StartGame();
                        break;
                    case 2:
                        Console.WriteLine("Showing options...");
                        break;
                    case 3:
                        Console.WriteLine("Exiting");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}
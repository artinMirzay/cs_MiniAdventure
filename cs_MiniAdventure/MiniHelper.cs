namespace cs_MiniAdventure
{
    public static class MiniHelper
    {
        public static void MainMenu()
        {
            Console.WriteLine("[1] Start Game");
            Console.WriteLine("[2] Options");
            Console.WriteLine("[3] Quit");
        }
        public static int ReadNumber() // Helper method to read and validate number input
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Enter a number");
            }
            return number;
        }
    }
}

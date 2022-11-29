namespace MyATMApp
{
    internal class MyATMApp
    {
        static void Main(string[] args)
        {

            //enjoying the console changes
            Console.Title = "My ATM App"; 
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            //prompting and welcoming the user
            Console.WriteLine("\n\nGreetings and welcome to The Wacky Warehouse: " +
                              "\nThe only place for all of your financial needs! " +
                              "\n\nPlease press Enter to continue...\n");
            Console.ReadLine();

        }
    }
}
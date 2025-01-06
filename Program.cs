namespace Battle_Boats;

class Program
{
    // Creates arrays of an 8 x 8 grid for the two required grids for each player, locations of their actual ships and locations of where they have hit 
    static char[,] player1FleetGrid = new char[8, 8];
    static char[,] player1TargetTracker = new char[8, 8];
    static char[,] player2FleetGrid = new char[8, 8];
    static char[,] player2TargetTracker = new char[8, 8];
    static bool gameInProgress = false;

    static void Main(string[] args)
    {
        MainMenu();
    }

    static void BlankGrids() // resets grids to be blank with dashes 
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                player1FleetGrid[i, j] = '-';
                player1TargetTracker[i, j] = '-';
                player2FleetGrid[i, j] = '-';
                player2TargetTracker[i, j] = '-';

            }
        }
    }

    static void MainMenu() // main menu that will be returned to multiple times
    {
        Console.Clear();
        Console.WriteLine("Battle Boats Menu: ");
        Console.WriteLine("     1. Start new game\n     2. Resume game\n     3. Show Instructions\n     4. Quit game");
        string userChoice = Console.ReadLine();

        switch (userChoice)
        {
            case "1":
                Console.WriteLine("New game");
                break;
            case "2":
                Console.WriteLine("Resume game");
                break;
            case "3":
                ShowInstructions();
                MainMenu();
                break;
            case "4":
                Console.Clear(); //TODO: quit game properly
                break;
        }
    }


static void ShowInstructions()
    {
        Console.Clear();
        Console.WriteLine("Battle Boats Instructions:");
        Console.WriteLine(" 1. Place 5 boats on your fleet grid.");
        Console.WriteLine(" 2. Take turns to fire at the opponent's grid.");
        Console.WriteLine(" 3. First to sink all opponent's boats wins.");
        Console.WriteLine(" Press Enter to return to the menu.");
        Console.ReadLine();
    }
}
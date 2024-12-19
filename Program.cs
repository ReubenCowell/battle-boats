namespace Battle_Boats;

class Program
{
    static char[,] player1FleetGrid = new char[8, 8];
    static char[,] player1TargetTracker = new char[8, 8];
    static char[,] player2FleetGrid = new char[8, 8];
    static char[,] player2TargetTracker = new char[8, 8];
    static bool gameInProgress = false;
    
    static void Main(string[] args)
    {
    }
    
    static void BlankGrids()
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

    static void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Battle Boats Menu: ");
        Console.WriteLine("1. Start new game\n2.Resume game\nShow Instructions\n3.Quit game");
        string userChoice = Console.ReadLine();

        switch (userChoice)
        {
            
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
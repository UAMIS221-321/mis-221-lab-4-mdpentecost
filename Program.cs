//MAIN
string userChoice =GetUserChoice();
while(userChoice!= "3")
{
    Console.Clear();
    RouteEm(userChoice);
    userChoice =GetUserChoice();
}
System.Console.WriteLine("bye");
//End Main


static string GetUserChoice()
{
    DisplayMenu();
    string userChoice=Console.ReadLine();
    if(IsValidChoice(userChoice))
    {
        return userChoice;
    }
    else {
        DisplayInvalid();
        string message = "Invalid Choice";
        return message;
    }

}

static void DisplayMenu()
{
    Console.Clear();
    System.Console.WriteLine("Please enter 1 to display full triangle\nPlease enter 2 to display partial triangle\nPlease enter 3 to exit");
}

static bool IsValidChoice(string userInput)
{
    if(userInput=="1" || userInput=="2"|| userInput=="3")
    {
        return true;
    } 
    return false;
}



static void DisplayFullTriangle()

{
    Random rnd= new Random(); // syntax for random
    int random= rnd.Next(3,10); //3 is inclusive 10 is exclusive
    System.Console.WriteLine("Full");
    for(int i=0; i !=random; i++ )
    {

        for(int j=0; j<i; j++)
        {
            System.Console.Write("O");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("Press any key...");
    Console.ReadKey();
    Console.Clear();
}

static void DisplayPartialTriangle()
{
    Random rnd= new Random(); // syntax for random
    int random= rnd.Next(3,10); //3 is inclusive 10 is exclusive
    System.Console.WriteLine("Full");
    for(int i=0; i !=random; i++ )
    {

        for(int j=0; j<i; j++)
        {
            if(rnd.Next(2)==0)
            {
                 System.Console.Write("O");
            }
            else System.Console.Write(" ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("Press any key...");
    Console.ReadKey();
    Console.Clear();

}

static void DisplayInvalid()
{
    System.Console.WriteLine("Invalid");
    System.Console.WriteLine("Press any key...");
    Console.ReadKey();
    Console.Clear();
}

static void RouteEm(string menuChoice)
{
    if(menuChoice=="1")
    {
        DisplayFullTriangle();
    }else if (menuChoice=="2")
    {
        DisplayPartialTriangle();
    }//else if (menuChoice=="3")
    // {
    //     System.Console.WriteLine("Goodbye");
    //     Environment.Exit(0);
    // }
    // else
    // DisplayInvalid();
    Console.Clear();


}

static void PauseAction() // to not enter infinite loop
{
    System.Console.WriteLine("Press any key to continue.");
    Console.ReadKey();
}

// for()
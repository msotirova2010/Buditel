const string Rock = "rock";
const string Paper = "paper";
const string Scissors = "scissors";

static void Main(string[] args)
{
    Console.WriteLine("Choose: rock, paper, scissors (or r, p, s)");
    string userChoice = Console.ReadLine().ToLower();

    if (userChoice == "r" || userChoice == Rock)
    {
        userChoice = Rock;
    }
    else if (userChoice == "p" || userChoice == Paper)
    {
        userChoice = Paper;
    }
    else if (userChoice == "s" || userChoice == Scissors)
    {
        userChoice = Scissors;
    }
    else
    {
        Console.WriteLine("Invalid choice.");
        return;
    }

    Random random = new Random();
    int computerChoice = random.Next(0, 3);
    string computerMove;

    int computerRandomNumber = 0;
    switch (computerRandomNumber)
    {
        case 0:
            computerMove = Rock;
            break;
        case 1:
            computerMove = Paper;
            break;
        case 2:
            computerMove = Scissors;
            break;
        default:
            computerMove = Rock;
            break;
    }

    Console.WriteLine($"The computer chose {computerMove}.");

    if (userChoice == computerMove)
    {
        Console.WriteLine("It's a tie!");
    }
    else if ((userChoice == Rock && computerMove == Scissors) ||
             (userChoice == Paper && computerMove == Rock) ||
             (userChoice == Scissors && computerMove == Paper))
    {
        Console.WriteLine("You win!");
    }
    else
    {
        Console.WriteLine("You lose!");
    }
}
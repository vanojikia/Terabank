class HomeWork4
{
    static void Main(string[] args)
    {
        //მთავარი ლოგიკის გამოძახება
        StartGame();

    }

    static void StartGame()
    {
        Welcome();
        tries();
    }

    static void Welcome()
    {
        Console.WriteLine("Hello, let's play a game...");
        Console.WriteLine();
        Console.WriteLine("Read the instructions before starting the game...");
        Console.WriteLine();
        Instruction();
    }

    static void Instruction()
    {
        Console.Write("Game rules: ");
        Console.WriteLine("I have a hidden number for you.");
        Console.WriteLine("This number is between 0 to 20.");
        Console.WriteLine("Your task is to guess the number.");
        Console.WriteLine("You have 3 attempts.");
    }

    static int randomNumber()
    {
        return new Random().Next(0, 21);
    }

    static int enterNumb()
    {
        Console.WriteLine();
        Console.Write("Enter a Number: ");
        return Int32.Parse(Console.ReadLine());
    }

    static void tries()
    {
        int retries = 0;
        while (retries < 3)
        {
            retries++;
            int randomNumb = randomNumber();
            int enterNumber = enterNumb();
            Console.WriteLine("Right number is: " + randomNumb);
            if (randomNumb == enterNumber)
            {
                Console.WriteLine("You have WON !");
                return;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Yo have Lose, Do you want to continue game? Y or N");
        string retrygame = Console.ReadLine();
        if (retrygame == "Y")
        {
            tries();
        }
        else
        {
            return;
        }

    }
}
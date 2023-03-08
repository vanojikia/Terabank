class Homework4
{

    /* დავწეროთ პროგრამა, რომელიც ჩაიფიქრებს რიცხვს 0-დან 20-ს ჩათვლით.
 * მომხმარებელმა უნდა გამოიცნოს ეს რიცხვი. მას აქვს სამი ცდა.
 * სამი ცდის შემდეგ, თუ რიცხვი ვერ გამოიცნო - წაგება, თუ რიცხვი გამოიცნო - მოგება.
 * გააგრძელოთ თამაშის დაწერა და დაასრულოთ. კერძოდ, მომხმარებელს უნდა ჰქონდეს შესაძლებლობა,
 * რომ სამჯერ სცადოს რიცხვის გამოცნობა. თუ რიცხვი მესამე ცდის შემდეგ ვერ გამოიცნო უნდა
 * გამოვიდეს შეტყობინება წაგების შესახებ. თუ გამოიცნო უნდა გამოვიდეს შეტყობინება გამარჯვების შესახებ.
 * 3. თუ შეძელით მეორე დავალების შესრულება უნდა დაუმატოთ შესაძლებლობა პროგრამას, რომ
 * მომხმარებელმა ხელახლა დაიწყოს თამაში.
 * ეს ყველაფერი კეთდება ციკლების მეშვეობით. კერძოდ, დაგჭირდებათ ორი ციკლი.
 */
    static void Main(string[] args)
    {
        startGame();
        tries();
    }

    /// <summary>
    /// ამ მეთოდით ხდება თამაშის დაწყება
    /// </summary>
    static void startGame()
    {
        Welcome();
    }


    /// <summary>
    /// ამ მეთოდით მომხმარებელს გამოსდის საინფორმაციო შეტყობინება
    /// </summary>
    static void Welcome()
    {
        Console.WriteLine("Hello, let's play a game...");
        Console.WriteLine();
        Console.WriteLine("Read the instructions before starting the game...");
        Console.WriteLine();
        Instruction();
    }


    /// <summary>
    /// ამ მეთოდით მომხმარებელს გამოსდის ინსტრუქცია
    /// </summary>
    static void Instruction()
    {
        Console.Write("Game rules: ");
        Console.WriteLine("I have a hidden number for you.");
        Console.WriteLine("This number is between 0 to 20.");
        Console.WriteLine("Your task is to guess the number.");
        Console.WriteLine("You have 3 attempts.");
    }


    /// <summary>
    /// ამ მეთოდით ხდება რენდომ რიცხვების დაგენერირება
    /// </summary
    static int randomNumber()
    {
        return new Random().Next(0, 21);
    }
    /// <summary>
    /// ამ მეთოდით ხდება მომხმარებლის მიერ რიცხვის შეყვანა
    /// </summary
    static int enterNumb()
    {
        Console.WriteLine();
        Console.Write("Enter a Number: ");
        return Int32.Parse(Console.ReadLine());
    }
    /// <summary>
    /// თამაში
    /// </summary>
    static void tries()
    {
        int retries = 0;
        int randomNumb = randomNumber();
        while (retries < 3)
        {
            retries++;
            int enterNumber = enterNumb();
            if (randomNumb == enterNumber)
            {
                Console.WriteLine("Right number is: " + randomNumb + " You have WON !");
                return;
            }else if (randomNumb < enterNumber)
            {
                Console.WriteLine("Entered number is higher");
            }else if (randomNumb > enterNumber)
            {
                Console.WriteLine("Entered number is lower");
            }
            else if (randomNumb < enterNumber)
            {
                Console.WriteLine("Entered number is higher");
            }
            else if (randomNumb > enterNumber)
            {
                Console.WriteLine("Entered number is lower");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Yo have Lose, Do you want to continue game? Yes - Y or No - N");
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
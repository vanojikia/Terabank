class HomeWork4
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
        //ამ მეთოდით ხდება მთავარი ლოგიკის გამოძახება
        StartGame();

    }


    /// <summary>
    /// ამ მეთოდით ხდება თამაშის დაწყება
    /// </summary>
    static void StartGame()
    {
        Welcome();
        tries();
    }


    /// <summary>
    /// ამ მეთოდით ხდება მისალმება
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
    /// ამ მეთოდით ხდება რენდომ რიცხვების შექმნა
    /// </summary>
    /// <returns></returns>
    static int randomNumber()
    {
        return new Random().Next(0, 21);
    }


    /// <summary>
    /// ამ მეთოდით მომხმარებელს შეყავს რიცხვი
    /// </summary>
    /// <returns></returns>
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

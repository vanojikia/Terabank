class Homework3
{
    static void Main(string[] args)
    {
        //1. მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს.
        Console.Write("Sum of x+y= ");
        Console.WriteLine(Sum(5, 4));
        Console.WriteLine();

        //2. მეთოდი, რომელსაც გამოაქვს ყველაზე დიდი და ყველაზე პატარა რიცხვი.
        Console.Write("Please, enter first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        double num3 = double.Parse(Console.ReadLine());

        Console.Write("Please, enter fourth number: ");
        double num4 = double.Parse(Console.ReadLine());

        Numbers(num1, num2, num3, num4);

        //3. მეთოდი, რომელსაც გადავცემთ ხილის სახელებს.
        Console.WriteLine();
        Fruits();
    }

    //1. შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს.
    //მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი.
    //გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.

    static int Sum(int x, int y)
    {
        int result = x + y;
        return x + y;
    }


    //2. შევქმნათ მეთოდი.
    //ვთხოვოთ მომხმარებელს შეიყვანოს ოთხი ნებისმიეირ ტიპის რიცხვი (ანუ არა მხოლოდ ინტეჯერი).
    //მეთოდის ფარგლებში უნდა მოიძებნოს ამ ოთხი რიცხვიდან ყველაზე დიდი და ყველაზე პატარა.
    //მეთოდმა უნდა გამოიყვანოს კონსოლში ეს ორი რიცხვი.

    static void Numbers(double num1, double num2, double num3, double num4)
    {
        if (num1 >= num2 && num1 >= num3 && num1 >= num4)
        {
            Console.WriteLine("The largest number is: " + num1);
        }
        else if (num2 >= num1 && num2 >= num3 && num2 >= num4)
        {
            Console.WriteLine("The largest number is: " + num2);
        }
        else if (num3 >= num1 && num3 >= num2 && num3 >= num4)
        {
            Console.WriteLine("The largest number is:" + num3);
        }
        else if (num4 >= num1 && num4 >= num2 && num4 >= num3)
        {
            Console.WriteLine("The largest number is: " + num4);
        }
        else
        {
            Console.WriteLine("These numbers is equal");
        }


        if (num1 <= num2 && num1 <= num3 && num1 <= num4)
        {
            Console.WriteLine("The smallest number is: " + num1);
        }
        else if (num2 <= num1 && num2 <= num3 && num2 <= num4)
        {
            Console.WriteLine("The smallest number is: " + num2);
        }
        else if (num3 <= num1 && num3 <= num2 && num3 <= num4)
        {
            Console.WriteLine("The smallest number is:" + num3);
        }
        else if (num4 <= num1 && num4 <= num2 && num4 <= num3)
        {
            Console.WriteLine("The smallest number is: " + num4);
        }
        else
        {
            Console.Write("");
        }
    }

    //3. შევქმნათ მეთოდი,
    //რომელმაც უნდა მიიღოს მეორე მეთოდის მეშვეობით მომხმარებლისგან ხილის დასახელება.
    //ამ ხილის დასახელების მიღების შემდეგ switch ოპერატორის მეშვეობით ნახოს თუ რომელი ხილია
    //და გამოიყვანოს შესაბამისი შეტყობინება.
    //თუ ასეთი ხილი არ მოიძებნა, ამის შესახებაც მომხმარებელმა უნდა მიიღოს შეტყობინება.
    //ხილი: apple, watermelon, melon, cherry, straweberry.

    static void Fruits()
    {
        Console.Write("Please, enter fruit: ");
        string FruitInput = Console.ReadLine();
        switch (FruitInput)
        {
            case "Apple":
                Console.WriteLine("This fruit is an Apple");
                break;
            case "Watermelon":
                Console.WriteLine("This fruit is a Watermelon");
                break;
            case "Melon":
                Console.WriteLine("This fruit is a Melon");
                break;
            case "Cherry":
                Console.WriteLine("This fruit is a Cherry");
                break;
            case "Straweberry":
                Console.WriteLine("This fruit is a Strawberry");
                break;
            default:
                Console.WriteLine("You have entered other fruit");
                break;

        }
    }
}



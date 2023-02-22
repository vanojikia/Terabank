class Homework3
{
    static void Main(string[] args)
    {
        Console.WriteLine(Numbers(5, 6));
    }

    //1. შევქმნათ მეთოდი, რომელსაც გადავცემთ ორ სრულ რიცხვს. მეთოდმა უნდა დააბრუნოს ორი რიცხვის ჯამი. გამოვიყვანოთ ეს ჯამი შესვლის წერტილის მეთოდის მეშვეობით კონსოლში.
    static int Numbers(int x, int y)
    {
        int sum = x + y;
        return sum;
    }
}
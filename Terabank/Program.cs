class Homework2
{
    static void Main(string[] args)
    {
        //Davaleba #1
        Console.Write("Please, enter the first number (X): ");
        int x = Int32.Parse(Console.ReadLine());
        Console.Write("Please, enter a second number (Y): ");
        int y = Int32.Parse(Console.ReadLine());
        Console.Write("Please, enter the third number (Z): ");
        int z = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Result (X+Z*Y)= ");
        Console.WriteLine(x+z*y);
        Console.WriteLine();
        Console.WriteLine();


        //Davaleba #2
        Console.Write("Please, enter your name: ");
        string firstname = Console.ReadLine();
        Console.Write("Please, enter your surname: ");
        string surname = Console.ReadLine();
        Console.Write("Please, enter your age: ");
        int age = Int32.Parse(Console.ReadLine());
        Console.Write("Please, enter your height (cm): ");
        int height = int.Parse(Console.ReadLine());
        Console.Write("Please, enter your weight (kg): ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Result: ");
        Console.WriteLine(firstname + " " + surname + "," + " " + age +"wlis" + "," + " " + height + "cm" + "," + " " + weight + "kg");
        Console.WriteLine();
        Console.WriteLine();


        //Davaleba #3
        Console.Write("Please, enter your weight (kg): ");
        double weight2 = double.Parse(Console.ReadLine());
        Console.Write("Please, enter your height (m): ");
        double height2 = double.Parse(Console.ReadLine());
        double bmi = weight2 / (height2 * height2);
        Console.WriteLine();
        Console.WriteLine("Your BMI Result (kg/m2): " + bmi);
        Console.WriteLine();
        Console.WriteLine();


        //Davaleba #4
        string vertical = "|";
        string horizontal = "---";
        Console.WriteLine();
        Console.WriteLine(" " + " " + " " + vertical + " " + " " + " " + vertical);
        Console.WriteLine(" " + "1" + " " + vertical + " " + "2" + " " + vertical + "3");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + "4" + " " + vertical + " " + "5" + " " + vertical + "6");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + "7" + " " + vertical + " " + "8" + " " + vertical + "9");
        Console.WriteLine(horizontal + vertical + horizontal + vertical + horizontal);
        Console.WriteLine(" " + " " + " " + vertical + " " + " " + " " + vertical);
    }
}


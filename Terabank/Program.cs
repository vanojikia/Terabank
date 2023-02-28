class Homework2
{
    static void Main(string[] args)
    {
        //Davaleba #1. შევქმნათ სამი ცვლადი (x, z, y).
        //მივანიჭოთ მნიშვნელობები.
        //გამოვიყვანოთ კონსოლში: x+z * y = ჯამი; მაგ. 4, 5, 10 - ის შედეგია 54.

        Console.Write("Please, enter the first number (X): ");
        int x = Int32.Parse(Console.ReadLine());
        Console.Write("Please, enter a second number (Y): ");
        int y = Int32.Parse(Console.ReadLine());
        Console.Write("Please, enter the third number (Z): ");
        int z = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Result (X+Z*Y)= ");
        Console.WriteLine(x + z * y);
        Console.WriteLine();
        Console.WriteLine();


        //Davaleba #2. პროგრამა სთავაზობს მომხმარებელს შეიყვანოს სახელი (Archil), გვარი(Sikharulidze), ასაკი(34), სიმაღლე(171) და წონა(88.7).
        //შევინახოთ ეს მონაცემები შესაბამისი ტიპის ცვლადებში.
        //გამოვიყვანოთ მთელი ინფორმაცია კონსოლში.

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
        Console.WriteLine(firstname + " " + surname + "," + " " + age + "wlis" + "," + " " + height + "cm" + "," + " " + weight + "kg");
        Console.WriteLine();
        Console.WriteLine();


        //Davaleba #3. დაწერეთ კოდი, რომელიც ითვლის ადამიანის BMI (Body Mass Index).
        //მოიძიეთ ფორმულა ინტერნეტში.
        //ლოგიკა და კოდი დამოუკიდებლად გაწერეთ.

        Console.Write("Please, enter your weight (kg): ");
        double weight2 = double.Parse(Console.ReadLine());
        Console.Write("Please, enter your height (m): ");
        double height2 = double.Parse(Console.ReadLine());
        double bmi = weight2 / (height2 / 100 * height2 / 100);
        Console.WriteLine();
        Console.WriteLine("Your BMI Result (kg/m2): " + bmi);
        Console.WriteLine();
        Console.WriteLine();


        //Davaleba #4. დამიხატეთ კონსოლში შემდეგი ნახატი.

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

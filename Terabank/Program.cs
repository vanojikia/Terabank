class Homework2
{
    static void Main(string[] args)
    {
        //Davaleba #1
        Console.Write("Gtxovt sheiyvanot pirveli ricxvi: ");
        int x = Int32.Parse(Console.ReadLine());
        Console.Write("Gtxovt sheiyvanot meore ricxvi: ");
        int y = Int32.Parse(Console.ReadLine());
        Console.Write("Gtxovt sheiyvanot mesame ricxvi: ");
        int z = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Migebuli shedegi: ");
        Console.WriteLine(x+y*z);

        Console.WriteLine();

        //Davaleba #2
        Console.Write("Gtxovt sheiyvanot tqveni saxeli: ");
        string saxeli = Console.ReadLine();
        Console.Write("Gtxovt sheiyvanot tqveni gvari: ");
        string gvari = Console.ReadLine();
        Console.Write("Gtxovt sheiyvanot tqveni asaki: ");
        int asaki = Int32.Parse(Console.ReadLine());
        Console.Write("Gtxovt sheiyvanot tqveni simagle (cm): ");
        int simagle = Int32.Parse(Console.ReadLine());
        Console.Write("Gtxovt sheiyvanot tqveni wona (kg): ");
        int wona = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Tqveni monacemebi: ");
        Console.WriteLine(saxeli + " " + gvari + "," + " " + asaki +"wlis" + "," + " " + simagle + "cm" + "," + " " + wona + "kg");
    }
}


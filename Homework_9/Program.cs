
class Program
{

    static void checkLine(ref string line, ref int numberCount)
    {
        line = line.ToUpper();
        foreach (var item in line)
        {
            if (Char.IsDigit(item))
            {
                numberCount++;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter line: ");
        string line = Console.ReadLine();

        int numberCount = 0;

        checkLine(ref line, ref numberCount);

        Console.WriteLine($"Reverse line: {line};\nNumbers in line {numberCount}.");
    }
}

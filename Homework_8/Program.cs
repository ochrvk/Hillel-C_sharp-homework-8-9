class Program
{

    static int[] CreateArray()
    {
        Console.Write("Array length: ");
        int arraylenght = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("___________________");

        int[] array = new int[arraylenght];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} element: ", i + 1);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("___________________");

        return array;
    }

    static bool FindNumber(int[] array, int number)
    {
        foreach (int i in array)
        {
            if (i == number)
            {
                return true;
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        int[] array = CreateArray();

        Console.Write("Enter value: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("___________________");

        Console.WriteLine($"Result: {FindNumber(array, number)}");

    }
}

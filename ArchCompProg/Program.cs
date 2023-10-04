using System;

class Program
{
    static string DecimalToBase(int number, int baseValue)
    {
        string result = "";

        while (number > 0)
        {
            int remainder = number % baseValue;
            result = remainder.ToString() + result;
            number = number / baseValue;
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Введiть десяткове число: ");
        int decimalNumber = int.Parse(Console.ReadLine());

        Console.Write("Введiть основу системи числення (2, 8 або 16): ");
        int baseValue = int.Parse(Console.ReadLine());

        if (baseValue != 2 && baseValue != 8 && baseValue != 16)
        {
            Console.WriteLine("Основа системи числення має бути 2, 8 або 16.");
        }
        else
        {
            string result = DecimalToBase(decimalNumber, baseValue);
            Console.WriteLine($"Результат переведення: {result}");
        }
    }
}

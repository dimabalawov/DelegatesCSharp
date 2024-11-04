using System;
using System.Collections.Generic;
using System.Linq;

public class ArrayOperations
{
    public static int[] GetEvenNumbers(int[] array) =>
        array.Where(x => x % 2 == 0).ToArray();

    public static int[] GetOddNumbers(int[] array) =>
        array.Where(x => x % 2 != 0).ToArray();

    public static int[] GetPrimeNumbers(int[] array)
    {
        return array.Where(IsPrime).ToArray();

        bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) return false;
            return true;
        }
    }

    public static int[] GetFibonacciNumbers(int[] array)
    {
        var fibs = new HashSet<int> { 0, 1 };
        int a = 0, b = 1;
        while (b <= array.Max())
        {
            int next = a + b;
            fibs.Add(next);
            a = b;
            b = next;
        }
        return array.Where(x => fibs.Contains(x)).ToArray();
    }
}

public class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };

        Func<int[], int[]> evenNumbers = ArrayOperations.GetEvenNumbers;
        Func<int[], int[]> oddNumbers = ArrayOperations.GetOddNumbers;
        Func<int[], int[]> primeNumbers = ArrayOperations.GetPrimeNumbers;
        Func<int[], int[]> fibonacciNumbers = ArrayOperations.GetFibonacciNumbers;

        Console.WriteLine("Четные числа: " + string.Join(", ", evenNumbers(numbers)));
        Console.WriteLine("Нечетные числа: " + string.Join(", ", oddNumbers(numbers)));
        Console.WriteLine("Простые числа: " + string.Join(", ", primeNumbers(numbers)));
        Console.WriteLine("Числа Фибоначчи: " + string.Join(", ", fibonacciNumbers(numbers)));
    }
}

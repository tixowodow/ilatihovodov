//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.



    // static void PrintNaturalNumbers(int m, int n)
    // {
    //     if (m <= n)
    //     {
    //         Console.Write(m + " ");
    //         PrintNaturalNumbers(m + 1, n);
    //     }
    // }

    // static void Main()
    // {
    //     // Введите значения M и N
    //     Console.Write("Введите значение M: ");
    //     int mValue = int.Parse(Console.ReadLine());

    //     Console.Write("Введите значение N: ");
    //     int nValue = int.Parse(Console.ReadLine());

    //     // Вызов функции для вывода натуральных чисел от M до N
    //     Console.WriteLine($"Натуральные числа от {mValue} до {nValue}:");
    //     PrintNaturalNumbers(mValue, nValue);
    // }





//Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


//using System;

// class Program
// {
//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//             return n + 1;
//         else if (m > 0 && n == 0)
//             return Ackermann(m - 1, 1);
//         else
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//     }

//     static void Main()
//     {
//         // Введите значения m и n
//         Console.Write("Введите значение m: ");
//         int mValue = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int nValue = int.Parse(Console.ReadLine());

//         // Вызов функции для вычисления функции Аккермана
//         int result = Ackermann(mValue, nValue);
//         Console.WriteLine($"Значение функции Аккермана для ({mValue}, {nValue}): {result}");
//     }
// }

// Задайте произвольный массив. Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.
using System;

class Program
{
    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            PrintArrayReverse(array, index - 1);
        }
    }

    static void Main()
    {
        // Произвольный массив
        int[] myArray = { 1, 2, 3, 4, 5 };

        // Вызов функции для вывода элементов массива с конца
        Console.WriteLine("Элементы массива в обратном порядке:");
        PrintArrayReverse(myArray, myArray.Length - 1);
    }
}

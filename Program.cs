// Задание 1
// PrintHeader("Заголовок 1");
// PrintHeader("Заголовок 2");
// static void PrintLine()
// {
//     Console.WriteLine("^_^");
// }
// static void PrintHeader(string title)
// {
//     PrintLine();
//     Console.WriteLine(title);
//     PrintLine();
// }

// Задание 2.1
// Console.WriteLine(Max(5, 10));
// Console.WriteLine(Max(42, 7));
// Console.WriteLine(Max(-3, -15));
// static int Max(int a, int b)
// {
//     if (a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
// }

// Задание 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));
// static bool IsEven(int n)
// {
//     return n % 2 == 0;
// }

// Задание 3
// int[] arr = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(arr));
// Console.WriteLine(CountGreater(arr, 100));
// static double Average(int[] arr)
// {
//     int sum = 0;
//     foreach (int x in arr)
//     {
//         sum += x;
//     }
//     return (double)sum / arr.Length;
// }
// static int CountGreater(int[] arr, int limit)
// {
//     int count = 0;
//     foreach (int x in arr)
//     {
//         if (x > limit)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// Задание 4
// double c1 = 0;
// Console.WriteLine($"{c1} °C = {ToFahrenheit(c1)} °F");
// double c2 = 100;
// Console.WriteLine($"{c2} °C = {ToFahrenheit(c2)} °F");
// double c3 = 37;
// Console.WriteLine($"{c3} °C = {ToFahrenheit(c3)} °F");
// static double ToFahrenheit(double celsius)
// {
//     return celsius * 9 / 5 + 32;
// }

// Задание 5
// Console.WriteLine(Factorial(5));
// for (int i = 2; i <= 50; i++)
// {
//     if (IsPrime(i))
//     {
//         Console.Write(i + " ");
//     }
// }
// Console.WriteLine();
// static long Factorial(int n)
// {
//     long result = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result *= i;
//     }
//     return result;
// }
// static bool IsPrime(int n)
// {
//     if (n < 2) return false;
//     for (int i = 2; i * i <= n; i++)
//     {
//         if (n % i == 0) return false;
//     }
//     return true;
// }

// Задание 6
// int a = ReadPositive("Введите первое положительное число: ");
// int b = ReadPositive("Введите второе положительное число: ");
// Console.WriteLine($"Сумма: {a + b}");
// static int ReadPositive(string message)
// {
//     int number;
//     do
//     {
//         Console.Write(message);
//         string input = Console.ReadLine();

//         if (!int.TryParse(input, out number))
//         {
//             Console.WriteLine("Ошибка: нужно ввести целое число.");
//             number = -1;
//         }
//         else if (number <= 0)
//         {
//             Console.WriteLine("Ошибка: число должно быть положительным.");
//         }

//     } while (number <= 0);
//     return number;
// }

// Итоговая задача. "Меню-калькулятор"
// while (true)
// {
//     Console.WriteLine("\n1 - сумма двух чисел");
//     Console.WriteLine("2 - большее из двух чисел");
//     Console.WriteLine("3 - факториал");
//     Console.WriteLine("0 - выход");
//     Console.Write("Выберите пункт: ");
//     string choice = Console.ReadLine();
//     switch (choice)
//     {
//         case "1":
//             Console.WriteLine($"Сумма: {Sum(ReadPositive("Введите первое число: "), ReadPositive("Введите второе число: "))}");
//             break;
//         case "2":
//             Console.WriteLine($"Большее: {Max(ReadPositive("Введите первое число: "), ReadPositive("Введите второе число: "))}");
//             break;
//         case "3":
//             Console.WriteLine($"Факториал: {Factorial(ReadPositive("Введите число: "))}");
//             break;
//         case "0":
//             return;
//         default:
//             Console.WriteLine("Нет такого пункта");
//             break;
//     }
// }
// static int ReadPositive(string message)
// {
//     int n;
//     do
//     {
//         Console.Write(message);
//     } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
//     return n;
// }
// static int Sum(int a, int b) => a + b;
// static int Max(int a, int b) => a > b ? a : b;
// static long Factorial(int n)
// {
//     long res = 1;
//     for (int i = 2; i <= n; i++) res *= i;
//     return res;
// }
// 

// Доп задание
// Console.WriteLine(Gcd(48, 18));
// Console.WriteLine(Lcm(4, 6));
// static int Gcd(int a, int b)
// {
//     while (b != 0)
//     {
//         int temp = b;
//         b = a % b;
//         a = temp;
//     }
//     return a;
// }
// static int Lcm(int a, int b)
// {
//     return a / Gcd(a, b) * b;
// }
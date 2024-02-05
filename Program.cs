// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

/* Console.Clear();
Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());
        
        PrintNumbersInRange(m, n);
        
    static void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbersInRange(m + 1, n);
        }
    }
 */

/* Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. */

/*  Console.Clear();
    
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
} */


/* Задайте произвольный массив. Выведете его элементы, 
начиная с конца. Использовать рекурсию, не использовать циклы. */

Console.Clear();
public class Task1
{
public static void Main(string[] args)
  {
  int[] myArray = { 1, 2, 3, 4, 5 };

    ReversePrint(myArray, myArray.Length - 1);
  }

    static void ReversePrint(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            ReversePrint(arr, index - 1);
        }
    }
}
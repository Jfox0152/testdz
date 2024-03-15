//Задача 1: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
int N = Convert.ToInt32(Console.ReadLine());
int M = Convert.ToInt32(Console.ReadLine());
Number(N, M);
Console.Write("end");

void Number(int N, int M)
{
  if (N > M) return;
  Number(N+1, M);
  Console.Write(N + ", ");
}

// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

Console.Clear();
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Prompt("Input M: ");
int n = Prompt("Input N: ");

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");
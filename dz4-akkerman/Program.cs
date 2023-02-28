// Написать программу вычисления функции Аккермана
int Akker(int n, int m)
{
  if (n == 0) return m + 1;
  if (n != 0 && m == 0) return Akker(n - 1, 1);
  if (n > 0 && m > 0) return Akker(n - 1, Akker(n, m - 1));
  return Akker(n, m);
}

int IntNum(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int n = IntNum("Введите число n: ");
int m = IntNum("Введите число m: ");

Console.WriteLine(Akker(n, m));
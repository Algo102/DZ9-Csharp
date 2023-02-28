// Написать программу возведения числа А в целую стень B
int PowAB(int a, int b)
{
  if (b == 0) return 1;
  else
    return PowAB(a, b - 1) * a;
}

int IntNum(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int a = IntNum("Введите число ");
int b = IntNum("Введите степень ");

Console.WriteLine($"Число {a} в степени {b} равно {PowAB(a, b)}");

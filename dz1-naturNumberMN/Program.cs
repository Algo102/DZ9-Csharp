// Показать натуральные числа от M до N, N и M заданы
void NaturNumb(int m, int n)
{
  if (m >= n)
  {
    Console.Write(m + " ");
    NaturNumb(m - 1, n);
  }
}

int IntNum(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int m = IntNum("Введите M ");
int n = IntNum("Введите N ");
NaturNumb(m, n);
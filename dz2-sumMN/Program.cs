// Найти сумму элементов от M до N, N и M заданы
int SumNumber(int M, int N)
{

  if (N < M)
    return 0;
  else
  {
    return N + SumNumber(M, N - 1);
  }

}

int IntNum(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int M = IntNum("Введите M ");
int N = IntNum("Введите N ");
Console.WriteLine("Сумма элементов " + SumNumber(M, N));


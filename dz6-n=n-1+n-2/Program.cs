// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

int SummDvuh(int n)
{
  if (n == 1 || n == 2) return 1;
  else return SummDvuh(n - 1) + SummDvuh(n - 2);
}

int IntNum(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int start = IntNum("Введите начало отсчета ");
int length = IntNum("Введите окончанее ряда ");

for (int i = start; i < length + 1; i++)
{
  Console.WriteLine(i + " = " + SummDvuh(i));
}



// Найти сумму цифр числа
int SumNumbers(int number)
{
  if (number < 1) return 0;
  return SumNumbers(number / 10) + number % 10;
}

int IntNum(string message)
{
  Console.WriteLine(message);
  return int.Parse(Console.ReadLine()!);
}

int number = IntNum("Введите число ");
Console.Write(SumNumbers(number));
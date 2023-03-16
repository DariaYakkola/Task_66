Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m >= n | n <= 1)
{
  Console.WriteLine("Натуральных чисел от M до N не существует! ");
  return;
}
/// <summary>
/// Метод который печатает сумму элементов в промежутке натуральных чисел
/// </summary>
/// <param name="start">Число от которого начинаем расчет</param>
/// <param name="end">Число до которого идет расчет</param>
/// <returns>Сумму элементов</returns>
int PrintSum(int start, int end)
{
  if (start <= 0)
  {
    start = 1;
  }
  int sum = start;
  if (start == end) return sum;
  {
    return (sum + PrintSum(start + 1, end));
  }
}
Console.WriteLine(PrintSum(m, n));
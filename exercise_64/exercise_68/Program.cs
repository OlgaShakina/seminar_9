// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}
Console.WriteLine("Введите два не отрицательных  M и N");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int functionAkkerman = Ack(m, n);
Console.Write($"Функция Аккермана = {functionAkkerman} ");
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

int Number(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}

void Cub(int chislo)
{
  for(int i = 1; i < chislo + 1; i++)
{
  Console.Write(Math.Pow(i, 3)+" ");
}
}

int chislo = Number("Введите целое положительное число");

Cub(chislo);
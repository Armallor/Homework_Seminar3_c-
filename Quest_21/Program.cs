// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве

int coordinat(string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine());
}

double distance(int[] x, int[] y, int[] z)
{
  return Math.Round(Math.Sqrt((Math.Pow((x[1]-x[0]), 2)) + (Math.Pow((y[1]-y[0]), 2)) + (Math.Pow((z[1]-z[0]), 2))), 2);
}


int[] x = new int[2];
int[] y = new int[2];
int[] z = new int[2];

x[0] = coordinat("Введите значение координаты первой точки по оси x: ");
y[0] = coordinat("Введите значение координаты первой точки по оси y: ");
z[0] = coordinat("Введите значение координаты первой точки по оси z: ");
x[1] = coordinat("Введите значение координаты второй точки по оси x: ");
y[1] = coordinat("Введите значение координаты второй точки по оси y: ");
z[1] = coordinat("Введите значение координаты второй точки по оси z: ");

double S = distance(x, y, z);
Console.Write($"Расстояние между точками равно {S}");

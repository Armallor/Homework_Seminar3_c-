// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом

string Number(string text)
{
  Console.Write(text);
  return (Console.ReadLine());
}

string chislo = Number("Введите пятизначное число: ");

if ((chislo[0] == chislo[4]) && (chislo[1] == chislo[3])) Console.WriteLine("Ура, палиндром");

else Console.WriteLine("Фу-х, непалиндром");
//Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится на два без остатка)

Console.WriteLine("Введите число ");
int usernumber = Convert.ToInt32(Console.ReadLine());

int digit3 = usernumber % 2;
if (digit3 == 0)
{
  Console.WriteLine("Четное");
}
else 
{
  Console.WriteLine("Нечетное");
}
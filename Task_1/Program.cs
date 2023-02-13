
//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 5; b = 25 -> да 
//a = 2 b = 10 -> нет 
//a = 9; b = -3 -> нет 
//a = -3 b = 9 -> да

Console.WriteLine ("Введите число A");
string userAnswerA = Console.ReadLine();
int numberA = Convert.ToInt32(userAnswerA);

Console.WriteLine ("Введите число B");
string userAnswerB = Console.ReadLine();
int numberB = Convert.ToInt32(userAnswerB);

if (numberB*numberB == numberA)
{
  Console.WriteLine("Yes");
}
else 
{
  Console.WriteLine ("No");
}

//Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше
//a=5;b= 7 -> max = 7, min = 5
//a=2;b= 10 -> max = 10, min = 2
//a=-9;b= -3 -> max = -3, min = -9

Console.WriteLine("Введите число A ");
string answerA = Console.ReadLine();
int usernumberA = Convert.ToInt32(answerA);

Console.WriteLine("Введите число B ");
string answerB = Console.ReadLine();
int usernumberB = Convert.ToInt32(answerB);

if (usernumberA > usernumberB)
{
  Console.WriteLine($"max={usernumberA}, min={usernumberB}");
}
else if (usernumberA < usernumberB)
{
  Console.WriteLine($"max={usernumberB}, min={usernumberA}");
}

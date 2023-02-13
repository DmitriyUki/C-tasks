//Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите число A");
string answerA = Console.ReadLine();
int usernumberA = Convert.ToInt32(answerA);

Console.WriteLine("Введите число B");
string answerB = Console.ReadLine();
int usernumberB = Convert.ToInt32(answerB);

Console.WriteLine("Введите число C");
string answerC = Console.ReadLine();
int usernumberC = Convert.ToInt32(answerC);

int max = usernumberA;

if (usernumberB > max) max = usernumberB;
if (usernumberC > max) max = usernumberC;

Console.Write("max = ");
Console.WriteLine(max);

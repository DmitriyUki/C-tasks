//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все четные счисла от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

  for (int i = 1; i <= N; i = i+1)
  {
    int digit3 = i % 2;
    if (digit3 == 0)
       {
       Console.WriteLine(i);
       }      
  }
  
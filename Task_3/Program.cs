//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.WriteLine ("Введите число");
string useranswer = Console.ReadLine();
int usernumber = Convert.ToInt32(useranswer);

if (usernumber == 1)
{
  Console.WriteLine ("Понедельник");
}
else if (usernumber == 2)
{
  Console.WriteLine ("Вторник");
}
else if (usernumber == 3)
{
  Console.WriteLine ("Среда");
}
else if (usernumber == 4)
{
  Console.WriteLine ("Четверг");
}
else if (usernumber == 5)
{
  Console.WriteLine ("Пятница");
}
else if (usernumber == 6)
{
  Console.WriteLine ("Суббота");
}
else if (usernumber == 7)
{
  Console.WriteLine ("Воскресенье");
}
else 
{
  Console.WriteLine ("Нет такого дня недели");
}
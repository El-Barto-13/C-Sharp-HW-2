// Home Work 2

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
*/
/*
Console.WriteLine("Введите нужное число: ");
int a = Convert.ToInt32(Console.ReadLine());

a = a / 10 % 10;

Console.WriteLine(a);
*/

//__________________

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
*/
/*
Console.Write("Введите нужное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int Third (int a)
  { 
    while(a >= 1000)
    {
     a = a / 10;
    }
    return a = a % 10;
  }
  if (a < 100)
    {
        Console.Write ("Нет третьей цифры");
    }
    
else 
Console.WriteLine(Third(a));
*/


//__________________

/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/
/*
Console.WriteLine("Введите число дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

bool SevenDays (int a)
    {
        if (a >= 1 && a <= 7)
        {
            return true;
        }
        return false;
    }
bool WorkingDay (int a)
    {
        if (a >= 1 && a <= 5)
            {
                return true;
            }
        return false;
    }

if(!SevenDays(a))
{
    Console.WriteLine("Такого дня в недели нет");
}
else if(WorkingDay(a))
{
    Console.WriteLine("ето Рабочий день");
}
else
{
    Console.WriteLine("ура...ето Выходной");
}
*/
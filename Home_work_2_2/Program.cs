// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 // что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = Math.Abs(num);
if ((num1 < 100)&&(num1 > -100))
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
   Console.WriteLine("Третья цифра в сумме "+num.ToString()+" = "+num1.ToString()[2]);
}
   

    
 


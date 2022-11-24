// Напишите программу, которая определяет, какие дни выходные.


Console.WriteLine("Введите число от 1 до 7 ");
//int num = Convert.ToInt32(Console.ReadLine());
int num = 1;
while (num <= 7)
{
    Console.WriteLine(num);
    if (num >= 6)
    {
        Console.WriteLine("Это выходной день ");
    }
    else
    {
        Console.WriteLine("Это не выходной день "); 
    }
    num++;
}
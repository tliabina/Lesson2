// Напишите программу, которая принимает на вход число и на выходе
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num);

int result = Math.Abs(num);

if (result >= 10)
{
    while(result >= 100)
    {
        result /= 10;
    }

    result = result % 10;

    Console.WriteLine(result);
} 
else
{
    Console.WriteLine("Слишком маленькое число");
}

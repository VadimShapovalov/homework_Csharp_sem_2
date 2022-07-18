//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

void SecondNumber(int num)
{
    if (num > 99 & num < 1000)
    {
        int y = num / 10;
        int z = y % 10;
        Console.WriteLine(z);
    }
    else
    {
        Console.WriteLine("Вы написали некорректное число");
    }
}

Console.WriteLine("Напишите трехзначное число: ");
int num = (Convert.ToInt32(Console.ReadLine()));
SecondNumber(num);
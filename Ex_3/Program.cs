//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//
//6 -> да
//7 -> да
//1 -> нет

void DayOfWeek (int num)
{
    if (num == 7 | num == 6)
        {
        Console.WriteLine("Выходной день!");
        }
    else if (num > 1 & num < 6)
        {
            Console.WriteLine("Будний день.");
        }
    else
    {
        Console.WriteLine("Вы ввели неверный символ. :-(");
    }
}

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
DayOfWeek (num);
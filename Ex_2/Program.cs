//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

void FindThirdDigital( int num )
{
    if (num > 999)
    {
        int x;
        while (num > 999)
        {
            num = num / 10;
        }
        x = num % 10;
        Console.WriteLine(x);
    }
    else Console.WriteLine("В напиcанном числе нет третьей цифры");
}
   
Console.WriteLine ("Напишите число: ");
int num = Convert.ToInt32(Console.ReadLine());
FindThirdDigital(num);

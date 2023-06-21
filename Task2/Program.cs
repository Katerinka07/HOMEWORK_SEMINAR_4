/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
int SumDigitsNumber(int number)
{
    int res = 0;
    while (number != 0)
    {
        res += number % 10;
        number = number / 10;
    }
    return res;
}
int num = InputNum("Введите целое число: ");
int sum = SumDigitsNumber(num);
Console.Write($"Cумма цифр в числе равна {sum}");

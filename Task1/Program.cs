/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int InputNum(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}
bool СheckdegreeNatural(int B)
{
    if (B <= 0)
    {
        Console.Write("Показатель степени не должен быть меньше или равен нулю");
        return false;
    }
    else
    return true;
}
int RaisingNumberAPowerB(int A, int B)
{
    int res = 1;
    for (int i = 1; i <= B; i++)
    {
        res*=A;
    }
    return res;
}
int A = InputNum("Введите число A: ");
int B = InputNum("Введите число B: ");
if (СheckdegreeNatural(B))
{
    Console.Write($"Число {A} в степени {B} равно {RaisingNumberAPowerB(A, B)} ");
}
















 
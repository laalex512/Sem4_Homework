/*Задача 27: Напишите программу, которая принимает на вход 5 чисел и выдаёт сумму цифр в каждом числе.
452 -> 11
82 -> 10
9012 -> 12*/

int SumDigit(int a)
{
    int sum = 0;
    while (a > 0)
    {
        sum = sum + a % 10;
        a = a / 10;
    }
    return sum;
}

int InputInt (string mes)
{
    Console.Write($"Insert {mes}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int num = InputInt("number1");
int sum = SumDigit(num);
Console.WriteLine(sum);








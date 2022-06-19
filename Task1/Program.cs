/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


int InputInt (string mes)
{
    Console.Write($"Insert {mes}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int a = InputInt("number A");
int b = InputInt("number B");
int result = 1;
for (int i = 0; i < b; i++)
{
    result = result*a;
}
Console.WriteLine("A^B = "+result);
/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

void FibonachiArr(int[] a)
{
    a[0] = 1;
    a[1] = 1;
    for (int i = 2; i < a.Length; i++)
    {
        a[i] = a[i - 1] + a[i - 2];
    }
}

void PrintArr(int[] a)
{
    Console.Write("[");
    for (int i = 0; i < a.Length - 1; i++)
    {
        Console.Write(a[i] + ", ");
    }
    Console.Write(a[a.Length-1] + "]");
    Console.WriteLine();
}


int[] array = new int[8];
int[] array2 = new int[20];



FibonachiArr(array);
FibonachiArr(array2);
PrintArr(array);
PrintArr(array2);


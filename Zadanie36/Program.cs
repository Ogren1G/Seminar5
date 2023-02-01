// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 100);
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void FindSum(int[] array)
{
    int sum = array[1] + array[3];
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum}");
}


int[] array = new int[4];
FillArray(array);
PrintArray(array);
FindSum(array);
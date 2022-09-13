////////////////////////_36_//////////////////////////

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write($"Введите размер массива: ");

int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int sum = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-100, 100);
}

for (int i = 1; i < size; i += 2)
{
    sum = sum + array[i];
}

Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна '{sum}'");

////////////////////////////_38_//////////////////////////

// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] array = { 3, 7, 22, 2, 78 };
double max = array[0];
double min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    else if (array[i] > max) max = array[i];
}

double diff = max - min;

Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Разница между максимальным числом '{max}' и минимальным числом '{min}' равна '{diff}'");
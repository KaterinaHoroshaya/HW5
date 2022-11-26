/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];

FillArrayRandomNumbers(numbers, 1, 99);
WriteArray(numbers);

double max = numbers[0];
double min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (max < numbers[i])
    {
        max = numbers[i];
    }
    if (min > numbers[i])
    {
        min = numbers[i];
    }
}

double dif = max-min;

Console.WriteLine($"{dif}");

void FillArrayRandomNumbers(double[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

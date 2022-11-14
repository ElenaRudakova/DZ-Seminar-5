// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество чисел в массиве: ");

int size = int.Parse(Console.ReadLine());

int [] array = new int [size];

int max = 0;
int min= 0;

for (int i =0; i<size; i++)
{
    array[i] = new Random().Next(100);

    min= array[0];
    max = array[0];

    Console.Write(array[i] + ", ");  
}

for (int i =0; i<size; i++)
{
    if(array[i]>max)
    {
        max = array[i];
    }

    if (array[i]<min)
    {
        min = array[i];
    }
}     

int result = max - min;

Console.WriteLine();
Console.WriteLine("Разница между max и min элементами массива: " + result);

// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2
int[] RandomArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void PrintArray(int[] N)
{
    for (int i = 0; i < N.Length; i++)
    {
    Console.Write($"{N[i]}");
    if (i != N.Length - 1)
    {
    Console.Write(", ");
    }
    }
}
int PosCount(int[] Ar)
{
    int count = 0;
    for (int i = 0; i < Ar.Length; i++)
    {
    if (0 == Ar[i] % 2)
    {
    count = count + 1;
    }
    }

    return count;
}
Console.Clear();
int[] Mass = RandomArray();
PrintArray(Mass);
Console.Write($" => {PosCount(Mass)}");

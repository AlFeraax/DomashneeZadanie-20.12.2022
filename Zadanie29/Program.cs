//Задание 29. Напишите программу, которая задаёт массив из 8 случайных чисел (-10, 10) и выводит их на экран.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10, 10);
        index++;
    }
}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos++;
    }

}
int[] array = new int[8];
FillArray(array);
PrintArray(array);
//Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitSum(int num)
{
    int count = Convert.ToString(num).Length;
    int step = 0;
    int res = 0;

    for (int i = 0; i < count; i++)
    {
        step = num - num % 10;
        res = res + (num - step);
        num = num / 10;
    }
    return res;
}

int digitSum = DigitSum(number);
Console.WriteLine("Сумма цифр в числе составляет: " + digitSum);
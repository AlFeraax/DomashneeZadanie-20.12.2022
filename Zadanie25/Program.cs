Console.WriteLine("Введите первое число:");
int chislo1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int chislo2 = Convert.ToInt32(Console.ReadLine());
int Stepen(int chislo1, int chislo2)
{
int res = 1;
for (int i = 1; i <= chislo2; i++)
{
res = res * chislo1;
}
return res;
}
int stepen = Stepen(chislo1, chislo2);
Console.WriteLine("Итогом возведения числа " + chislo1 + " в степень числа " + chislo2 + " является число " + stepen);
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Все четные числа от 1 до числа N: ");
for (int i = 2; i < n; i=i+2)
{
    Console.WriteLine(i);
}

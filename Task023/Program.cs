// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Qube(int n)
{
    Console.Write($"{n}  -> ");

    int i = 1;
    while (i < n)
    {
        Console.Write($" {i*i*i}, ");
        i++;
    }
    Console.WriteLine($" {n * n * n}.");
}
Qube(4);
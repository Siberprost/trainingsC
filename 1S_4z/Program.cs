//7. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
void Zadacha7()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int start = -num;
    while (start<= num)
    {
        Console.Write(start + " ");
        start++;
    }
    Console.WriteLine();
}
Zadacha7();
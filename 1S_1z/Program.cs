Console.Write("Введите число 1: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if(number_2 == number_1 * number_1)
{
    Console.WriteLine("2 число является квадратом первого");
}
else
{
    Console.WriteLine("2 число не является квадратом первого");

}
Console.Write("Введите число дня недели: ");
int number_week = Convert.ToInt32(Console.ReadLine());

if(number_week == 3)
{
    Console.WriteLine("Среда, пить рано!");
}
if(number_week == 5)
{
    Console.WriteLine("Пятница, сегодя вечером нажрусь!");
}
else
{
    Console.WriteLine("Указано некорректное число недели");

}
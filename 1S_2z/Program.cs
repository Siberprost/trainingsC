Console.Write("Введите число дня недели: ");
int number_week = Convert.ToInt32(Console.ReadLine());

if(number_week == 1)
{
    Console.WriteLine("Понедельник, земля гудроном!");
}
else if(number_week == 2)
{
    Console.WriteLine("Вторник, разгоняйся!");
}
else if(number_week == 3)
{
    Console.WriteLine("Среда, пить рано!");
}
else if(number_week == 4)
{
    Console.WriteLine("Четверг, Ещё чуть-чуть!");
}
else if(number_week == 5)
{
    Console.WriteLine("Пятница, сегодя вечером нажрусь!");
}
else if(number_week == 6)
{
    Console.WriteLine("Суббота, болеешь?");
}
else if(number_week == 7)
{
    Console.WriteLine("Воскресенье, живи, завтра на работу!");
}
else
{
    Console.WriteLine("Указано некорректное число недели");

}
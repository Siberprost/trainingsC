//9. Напишите программу, которая выводит случайное 
//число из отрезка [10, 99] и показывает наибольшую 
//цифру числа.

Random rand = new Random();
//<Тип данных> имя = new <тип данных>();
int num = rand.Next(10,100);
Console.WriteLine (num);

int ones = num % 10; // 84 % 10 = 4
int tens = num / 10; // 84/10=8 (целочисленное деление)
Console.WriteLine("десятая " +  ones);
Console.WriteLine("единичная " + tens);

if (ones > tens) Console.WriteLine ("Большее- " + ones);
else Console.WriteLine("большее- " + tens);
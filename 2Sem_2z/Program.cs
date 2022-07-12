//11. Напишите программу, которая выводит случайное 
//трёхзначное число и удаляет вторую цифру этого 
//числа. 456 -> 46  782 -> 72   918 -> 98



Random rand = new Random();
int num = rand.Next(100,1000);
Console.WriteLine ("случайное число " + num);

int ones = num % 10; // 84 % 10 = 4
int tens = num / 10; // 84/10=8 (целочисленное деление)
int hundr = num / 100;

int result = ones+hundr*10;
Console.WriteLine ("число после обработки " + result);
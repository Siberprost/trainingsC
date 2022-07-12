//16. Напишите программу, которая принимает на вход два числа и 
//проверяет, является ли одно число квадратом другого.

Console.Write("Введите число 1: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1*num_1 == num_2)
    Console.WriteLine("Число " + num_1 + " является квадратом числа " + num_2);
else if (num_2*num_2 == num_1)
        Console.WriteLine("Число " + num_2 + " является квадратом числа " + num_1);
else Console.WriteLine("Число " + num_1 + " не является квадратом числа " + num_2);

// можно аписать как if (num_1*num_1 == num_2 || num_2*num_2 == num_1)

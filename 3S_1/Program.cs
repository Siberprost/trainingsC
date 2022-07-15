void Zadacha17()
{

//17. Напишите программу, которая принимает на вход координаты 
//точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.

Random random = new Random();
int x = random.Next(-10, 11);
int y = random.Next(-10, 11);
Console.WriteLine($"точка с координатами ({x}, {y})");
if (x > 0 && y > 0) Console.WriteLine("1 четверть");
else if (x < 0 && y > 0) Console.WriteLine("2 четверть");
else if (x < 0 && y < 0) Console.WriteLine("3 четверть");
else if (x > 0 && y < 0) Console.WriteLine("4 четверть");
else Console.WriteLine ("точка лежит на оси координат");
}

// c ручным вводом ниже
void Zadacha17_2()
{
Console.WriteLine("Введите координаты точки");
    Console.WriteLine("x:");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y:");
    int y = Convert.ToInt32(Console.ReadLine());    
    Console.WriteLine($"Координата точки ({x},{y})");
    if (x>0 && y>0) Console.WriteLine("Первая четверть");
    else if (x>0 && y<0) Console.WriteLine("Вторая четверть");
    else if (x<0 && y<0) Console.WriteLine("Третья четверть");
    else if (x<0 && y>0) Console.WriteLine("Четвертая четверть");
    else if (x==0 && y==0) Console.WriteLine("Начало координат");
    else if (x==0) Console.WriteLine("Точка лежит на оси OX");
    else if (y==0) Console.WriteLine("Точка лежит на оси OY");
}


void Zadacha18()
{
//Задача 18: Напишите программу, которая по заданному номеру 
//четверти, показывает диапазон возможных координат точек в этой 
//четверти (x и y).

Console.WriteLine("Введите номер координатной четверти 1,2,3 или 4");
int x = Convert.ToInt32(Console.ReadLine());


if (x==1) Console.WriteLine ("x > 0 && y > 0");
else if (x==2) Console.WriteLine ("x < 0 && y > 0");
else if (x==3) Console.WriteLine ("x < 0 && y < 0");
else if (x==4) Console.WriteLine ("x > 0 && y < 0");
else Console.WriteLine ("некорректное значение");

}

void Zadacha21()
{
//Задача 21: Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между ними в 
//2D пространстве.

Console.WriteLine("Введите координаты точки 1");
    Console.WriteLine("x:");
    int xA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y:");
    int yA = Convert.ToInt32(Console.ReadLine());    
Console.WriteLine("Введите координаты точки 2");
    Console.WriteLine("x:");
    int xB = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("y:");
    int yB = Convert.ToInt32(Console.ReadLine());  
//расстояние можно вычислить по формуле треугольника (через катеты)
//(НУЖНАЯ)гипотенуза равна корень квадратный из суммы квадратов катетов 
//(КЛАССИЧЕСКАЯ)гипотенуза равна сумме квадратов катетов
//расстояние между точками в 2D = сумма квадратов разности
// соответствующих координат

//возведение в корень Math.Pow(num, 2)
//извлечение корня MathSqrt(num, 2)

double yy = Math.Pow(yA - yB, 2);
double xx = Math.Pow(xA - xB, 2);

double S = Math.Sqrt (yy + xx);

S = Math.Round(S, 2); //функция для округления S переменная? 2 - до скольки знаков после запятой.

Console.WriteLine (S);

}

void Zadacha22()
{
//Задача 22: Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число");
    Console.WriteLine("N:");
    int n = Convert.ToInt32(Console.ReadLine());

int strt = 1;
while (strt <= n)
{
Console.Write (strt*strt + "|  |");
strt++;
}
}




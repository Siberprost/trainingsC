//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
void Zadacha24()
{
    //Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
    Console.WriteLine("Введите числ для надругательства");
    int a = Convert.ToInt32(Console.ReadLine());
    int summ = 0;
    
    for (int i = 1; i <= a; i++)
    {
        summ += i;
    }
    Console.WriteLine($"Мумма чисел от 1 до {a} равна {summ}");
}

//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
void Zadacha26()
{
    //Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
    Console.WriteLine("Введите числ для проверки кол-ва символов");
    string a = Console.ReadLine();
    int count = a.Length;
     Console.WriteLine($"Количество символов в числе равно {count}");

}
void Zadacha26V2() // ненадёжный, но считающий именно по цирам метод. При сложном и длинном числе ломается консоль, не видит нули в начале
{
    Console.WriteLine("Введите числ для надругательства");
    int num = Convert.ToInt32(Console.ReadLine());
    int temp = 0;

    while (num>0)
    {
        num = num/10;
        temp++;
    }
    Console.WriteLine($"В указанном числе {temp} число цифр");
}

//Задача 28: Напишите программу, которая принимает на вход число (А) и выдаёт произведение чисел от 1 до А.
void Zadacha28()
{
    //Задача 28: Напишите программу, которая принимает на вход число (А) и выдаёт произведение чисел от 1 до А.
    Console.WriteLine("Введите числ для надругательства");
    int a = Convert.ToInt32(Console.ReadLine());
    int summ = 1;
    
    for (int i = 1; i <= a; i++)
    {
        summ *= i;
    }
    Console.WriteLine($"Произведение чисел от 1 до {a} равна {summ}");
}

//Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. Пример:[1,0,1,1,0,1,0,0]
void Zadacha30()
{
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        //в строке выше мы присваеваем индексу рандомное значение от 0 до 1
        index++;
    }
}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}
int[] array = new int[8];
FillArray(array);
PrintArray(array);

}
//второй вариант решения задачи 30, довольно массивный, но можно самому выбрать длинну массива через консоль
void Zadacha30V2()

{
    Console.WriteLine("какой длинны массив хотите?");
    int size = Convert.ToInt32(Console.ReadLine());
    
    int[] array = new int[size];
    int x;

    for (int i = 0; i < size; i++)
    {
        Random rand = new Random ();
        x = rand.Next(0,2);
        array[i] = x;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
//третий вариант решения задачи 30, попроще, меньше масса кода, но размер массива чётко зафиксирован в коде
void Zadacha30V3()
{
    
    int [] array = new int [8];
    int i = 0;
    
    while (i<array.Length)
    {
        int num = new Random().Next(0,2);
        array [i] = num;
        Console.Write(num + " ");
        i++;
    }
}
// четвёртый вариант- идеальный
void Zdadcha30Excelent()
{
    Console.WriteLine("какой длинны массив хотите?");
    int size = Convert.ToInt32(Console.ReadLine());
    int [] array = new int[size];

    Random rand = new Random();// данная строка выведена вне цикла для оптимизации. Если оставить в цикле, то каждое прохождение цикла будет создаваться новый (объект)"работник" ранд
    for (int i = 0; i<size; i++)
    {
        array[i] = rand.Next(0,2);
    }

    for (int i = 0; i<size; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}

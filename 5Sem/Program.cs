//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
void zadacha31()
{
    Console.WriteLine("какой длинны массив хотите?");
    int size = Convert.ToInt32(Console.ReadLine());
    int[]array = new int[size];

    Console.WriteLine("минимальное значение числа в массиве?");
    int startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("максимальное значение числа в массиве?");
    int finishNum = Convert.ToInt32(Console.ReadLine());

MassiveFillerFix(array, startNum, finishNum);
PrintArray(array);

    //теперь решаем задачу с суммами отриц и полож-х элементов
    int positiveSumm = 0;
    int NegativeSumm = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] > 0) positiveSumm += array[i]; // если рассматриваемый элемент массива больше нуля, то к сумме положительных прибавляем значение рассматрвиаемого элемента
        else if (array[i] < 0) NegativeSumm += array[i]; // если рассматриваемый элемент массива меньше нуля, то к сумме отрицательных прибавляем значение рассматрвиаемого элемента
    }
    Console.WriteLine ("Сумма положительных элементов равна " + positiveSumm);
    Console.WriteLine ("Сумма отрицательных элементов равна " + NegativeSumm);


    void MassiveFillerFix(int[] array, int startNum, int finishNum) // заполняет массив рандомными числами от -10 до 10, но по другому- проще.
    {
    finishNum++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(startNum, finishNum);
        }
  
    }
    void PrintArray(int[] array)
    {
        Console.WriteLine("Вывод масссива: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

}
//zadacha31();

//Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
void zadacha32()
{
    Console.WriteLine("какой длинны массив хотите?");
    int size = Convert.ToInt32(Console.ReadLine());
    int[]array = new int[size];

    Console.WriteLine("минимальное значение числа в массиве?");
    int startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("максимальное значение числа в массиве?");
    int finishNum = Convert.ToInt32(Console.ReadLine());

MassiveFillerFix(array, startNum, finishNum);
PrintArray(array);

    //теперь решаем задачу с заменой элементов массива
    for (int i = 0; i < size; i++)
    {
        array[i] *= -1;
    }
PrintArray(array);


    void MassiveFillerFix(int[] array, int startNum, int finishNum) // заполняет массив рандомными числами от -10 до 10, но по другому- проще.
    {
    finishNum++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(startNum, finishNum);
        }
  
    }
    void PrintArray(int[] array)
    {
        Console.WriteLine("Вывод масссива: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
//zadacha32();


// Задача 33: Задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве
void zadacha33()
{
    Console.WriteLine("какой длинны массив хотите?");
    int size = Convert.ToInt32(Console.ReadLine());
    int[]array = new int[size];

    Console.WriteLine("минимальное значение числа в массиве?");
    int startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("максимальное значение числа в массиве?");
    int finishNum = Convert.ToInt32(Console.ReadLine());

MassiveFillerFix(array, startNum, finishNum);
PrintArray(array);

    //теперь решаем задачу с проверкой наличия числа в массиве
Console.WriteLine ("Введите искомый элемент");
int finder = Convert.ToInt32(Console.ReadLine());
bool flagFinder = false; // вводим булево значение, которое отвечает только на вопрос "истина или ложно"
for (int i = 0; i < size && !flagFinder; i++)// цикл продолжается пока не закончился размер массива или пока флаг не перестанет быть ложным. ! это знак отрицания (делает "неложь)
{
    flagFinder = finder == array[i]; // == - сравнение
}
if (flagFinder) Console.WriteLine("элемент " + finder + " есть в массиве");
else Console.WriteLine("элемент не найден в массиве");

    void MassiveFillerFix(int[] array, int startNum, int finishNum) // заполняет массив рандомными числами от -10 до 10, но по другому- проще.
    {
    finishNum++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(startNum, finishNum);
        }
  
    }
    void PrintArray(int[] array)
    {
        Console.WriteLine("Вывод масссива: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
//zadacha33();

// задача 35 
// Задать массив. Случайные числа. Найти кол-во элементов массива, значения которых лежат в отрезке [10,99
void zadacha35()
{
    Console.WriteLine("какой длинны массив хотите?");
    int size = Convert.ToInt32(Console.ReadLine());
    int[]array = new int[size];

    Console.WriteLine("минимальное значение числа в массиве?");
    int startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("максимальное значение числа в массиве?");
    int finishNum = Convert.ToInt32(Console.ReadLine());

MassiveFillerFix(array, startNum, finishNum);
PrintArray(array);

    //теперь решаем задачу с поиском кол-ва искомых элементов [от 10 до 99]
    int count = 0; //счётчик искомых элементов
    Console.WriteLine("начало отрезка");
    int strtRange = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("конец отрезка");
    int endRange = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= strtRange && array[i] <= endRange) count++; // если значение массива соответствует отрезку 10-99, то значение count увеличивается на 1, а это и есть счётчик элементов

    }
    Console.WriteLine("В массиве " + count + " искомых елементов");

    void MassiveFillerFix(int[] array, int startNum, int finishNum) // заполняет массив рандомными числами от -10 до 10, но по другому- проще.
    {
    finishNum++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(startNum, finishNum);
        }
  
    }
    void PrintArray(int[] array)
    {
        Console.WriteLine("Вывод масссива: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
//zadacha35();

//задача 37
// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат записать в отдельном массиве.
void zadacha37()
{
 Console.WriteLine("какой длинны массив хотите?");
    int size = Convert.ToInt32(Console.ReadLine());
    int[]array = new int[size];

    Console.WriteLine("минимальное значение числа в массиве?");
    int startNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("максимальное значение числа в массиве?");
    int finishNum = Convert.ToInt32(Console.ReadLine());

MassiveFillerFix(array, startNum, finishNum);
PrintArray(array);

    //теперь решаем задачу с перебором массива и выстраиванием нового
    int halfSize = size / 2; // для оптимизации нашли полмассива (т.к. пересчитывать потребуется до середины массива т.к. пересчёт будет с обееих сторон)
    int maxIndex = size - 1; // максимальный индекс всегда размер минус 1
    for (int i = 0; i < halfSize; i++)
    {
         Console.Write(array[i] * array[maxIndex - i] + "  " );// т.к. первый элемент i всегда равен 0, то всё ок. с каждым сл. переходом элементы будут сдвигаться на 1 ед к себе
    }
    if (size %2 == 1)
    {
        Console.Write(array[halfSize]); // выводит оставшийся элемент, если число нечётное
    }
    

    void MassiveFillerFix(int[] array, int startNum, int finishNum) // заполняет массив рандомными числами от -10 до 10, но по другому- проще.
    {
    finishNum++;
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(startNum, finishNum);
        }
  
    }
    void PrintArray(int[] array)
    {
        Console.WriteLine("Вывод масссива: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
zadacha37();





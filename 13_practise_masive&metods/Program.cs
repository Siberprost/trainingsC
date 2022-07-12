void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //в строке выше мы присваеваем индексу рандомное значение от 1 до 10
        index++;
    }
}
// создан "метон" ака "функция", которая заполняет все значения массива рандомными числами от 1 до 10.

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
// создан "метод" ака "функция", которрая выводит на экран значения с первого по последнее на экран


int[] array = new int[10];
// конструкция new int[10] значит "создай новый массив, в котором будет 10 элементов. По умолчанию он зполняется нулями. Чтобы заполнить использовали код с 1 по 12 строку. 

FillArray(array);
PrintArray(array);
//пояснение- 
//строка 27- определили, что существует массив из 10 элементов
//строка 30 - заполнили массив с момощью метода FillArray
//строка 31 - вывели на экран результат отработки строк 27 и 30 с помощью метода PrintArray

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

//int a1 = 15;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12; это перечисление мы преобразовали в массив ниже
//int b2 = 23;
//int c2 = 33;
//int a3 = 13;
//int b3 = 23;
//int c3 = 333;
int[] array = {15,21,39,12,23,33,13,23,333};
//              0  1  2  3 4  5  6  7   8   - порядок чисел в массиве, начинается с нуля и по возрастанию 

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2); это вычисление мы ужали до одной строки ниже
//int max3 = Max(a3, b3, c3);

//int max= Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); то, как это было без массива
int max= Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max);
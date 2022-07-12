int[] array = { 1, 12, 31, 18, 4, 15, 16, 17, 18 };

int n = array.Length;
// array.Lenght возвращает нам инфу о длинне массива
int find = 18;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
        // break - оператор прерывания после нахождеения первого искомого значения. Если в массиве несколько одинаковых искомых значений, то без break нам покажут все, с break первый.
    }
    index++;
    //index = index + 1;
}

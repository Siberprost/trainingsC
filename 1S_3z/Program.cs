// Напишите программу вычисления значения 
//функции возведения числа в квадрат

//функция должна возвращать значение для этого return

int Power(int currentNumber)
{
    return currentNumber * currentNumber;
}
// в строках 6-7 мы сделали СВОЮ функцию и назвали ее POWER и она выполняет задачу.

int number = 5;
int result = Power(number);
Console.WriteLine(result);
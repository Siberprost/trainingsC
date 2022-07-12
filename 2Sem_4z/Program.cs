//14. Напишите программу, которая принимает на вход число и 
//проверяет, кратно ли оно одновременно 7 и 23.

//int num = 5;
// 1 < num < 10
                                // num > 1 & num  < 10
//if (num > 1 && num < 10)
//{
//    Console.WriteLine("Число лежит в промежутке от 1 до 10");
//}

Console.Write("Введите число 1: ");
int num = Convert.ToInt32(Console.ReadLine());

//if (num % 7 == 0)
  //      if (num % 23 ==0)
    //        Console.WriteLine("yes");
      //  else 
        //    Console.WriteLine("no");
   // else
     //   Console.WriteLine("no");
     //можно записать короче
if (num % 7 == 0 && num % 23 == 0)
    Console.WriteLine("yes");
else Console.WriteLine("no");

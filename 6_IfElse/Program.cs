Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username == "Siber")
{
    Console.WriteLine("Привет, хозяин!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
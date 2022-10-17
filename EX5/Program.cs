Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ириша")
{
    Console.WriteLine("Урррааа, привет Ириша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
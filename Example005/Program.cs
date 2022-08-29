Console.Write("введите имя пользователя");
string username = Console.ReadLine();
if(username.ToLower() == "миша")
{
    Console.WriteLine("уходи,Миша");
}
else
{
    Console.Write("привет");
    Console.WriteLine(username);
}
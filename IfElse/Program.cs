Console.Write("Input name of User: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.WriteLine("Yep, it's Masha!");
}
else
{
    Console.Write("Hi, ");
    Console.Write(username);
}

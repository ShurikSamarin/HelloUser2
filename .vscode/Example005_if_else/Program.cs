Console.Write("Input your name ");
string username = Console.ReadLine();
if(username.ToLower() == "mary")
{
    Console.WriteLine("Hooray Mary");
}
else
{
    Console.Write("Hi,");
    Console.WriteLine(username);
}
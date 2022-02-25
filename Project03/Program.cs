Console.WriteLine("=======Задача № 6=======");
Console.WriteLine("ННапишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
try
{
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("n = " + n + " -> ");
    if ((n % 2) == 0)
    {
        Console.WriteLine ("да");
    }
    else
    {
        Console.WriteLine("нет");
    }

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

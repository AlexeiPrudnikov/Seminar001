Console.WriteLine("=======Задача № 2=======");
Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
try
{
    Console.Write("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("a = " + a + " b = " + b + " -> max = ");
    if (a > b)
    {
        Console.WriteLine (a);
    }
    else
    {
        Console.WriteLine(b);
    }

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

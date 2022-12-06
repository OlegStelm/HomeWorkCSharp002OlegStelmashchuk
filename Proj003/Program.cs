int a;

Console.WriteLine("Enter a number: ");
int.TryParse(Console.ReadLine(), out a);

if (a<=7 && a>=1)
{
    if (a==6 || a==7)
    {
        Console.Write("WOW! Today is a day off!");
    }
    else
    {
        Console.Write("Wake up! Go to work!");
    }
}
else
{
    Console.Write("The day of the week with this number has not yet been invented!");
}

int a;

Console.WriteLine("enter a number: ");
int.TryParse(Console.ReadLine(), out a);
if (a>=100 && a<=999 || a<=-100 && a>=-999)
{
    if (a<0)
    {
        a=-a;
    }
    a=((a-a % 10)/10)%10;
    Console.Write($"figure number two = {a} ");
}
else
{
    Console.Write($"WTF? This number is not three digits!");
}
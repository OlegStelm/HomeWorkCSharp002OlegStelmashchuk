int a;

Console.WriteLine("Enter a number: ");
int.TryParse(Console.ReadLine(), out a);
int i=0;
if (a>=100 || a<=-100)
{
    for (i=a; i>999; i=((i-i % 10)/10))
    {
        
    }
    a=i;
    if (a<0)
    {
        a=-a;
    }
    a=a % 10;
    Console.Write($"figure number three = {a} ");
}
else
{
    Console.Write($"Really? There is no third number!");
}
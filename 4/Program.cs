Console.Clear();
Console.WriteLine ("введите три числа:");

var numberA = Convert.ToInt32(Console.ReadLine());
var numberB = Convert.ToInt32(Console.ReadLine());
var numberC = Convert.ToInt32(Console.ReadLine());

int Max = numberA;

if (numberB > Max)
{
    Max = numberB;
}
if (numberC > Max) 
{ 
    Max = numberC;
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine (Max);
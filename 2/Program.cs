Console.Clear();
Console.WriteLine ("введите два числа:");

var numberA = Convert.ToInt32(Console.ReadLine());
var numberB = Convert.ToInt32(Console.ReadLine());



if (numberA >  numberB)

{
    Console.WriteLine ();
    Console.Write("max=");
    Console.WriteLine(numberA);
   }

else
{
    Console.WriteLine();
    Console.Write("max=");
    Console.WriteLine(numberB);
}
if (numberA ==  numberB)
{
    Console.WriteLine ();
    Console.Write("числа равны");
}

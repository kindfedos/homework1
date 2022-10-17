Console.Clear();
Console.WriteLine ("введите число");

var numberA = Convert.ToInt32(Console.ReadLine());


for (int i = 2; i <= numberA; i += 2)
Console.WriteLine(i);

Console.Clear();
Console.WriteLine ("введите число");

var numberA = Convert.ToInt32(Console.ReadLine());


if (numberA % 2 == 1)
{
  Console.WriteLine(" Число " + numberA + " нечетное ");
}

else
{
   Console.WriteLine(" Число " + numberA + " четное ");
}


  
Console.WriteLine("Triangle Type identifier");
Console.WriteLine("First side: ");
int Side1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Second side: ");
int Side2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Third side: ");
int Side3 = Convert.ToInt32(Console.ReadLine());


if (Side1 == Side2 && Side1 == Side3)
{
    Console.WriteLine("All 3 sides are equal hence it is an Equilateral Triangle");
}
else if ((Side1 != Side2 && Side1 == Side3) || (Side1 == Side2 && Side1 != Side3) || (Side2 != Side1 && Side2 == Side3))
{
    Console.WriteLine("2 sides are equal hence it is a Isoceles Triangle");
}
else{
    Console.WriteLine("All 3 sides are not equal hence it is an Scalene Triangle");
}

Thread.Sleep(5000);
Environment.Exit(0);

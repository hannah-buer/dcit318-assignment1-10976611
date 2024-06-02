int age;
int PriceOfTicket = 10;
int NewPriceOfTicket = 7;
while (true)
{
    Console.WriteLine("Enter age: ");
    
    if(!int.TryParse(Console.ReadLine(),out age))
    {
        Console.WriteLine("Please enter a valid integer. ");
        continue;
    }
    if (age < 0)
    {
        Console.WriteLine("Please enter a valid age.");
    }
    if (age >= 0){
        if (age > 64 || age < 13)
        {
            Console.WriteLine("Amount due: " + NewPriceOfTicket+"GHC");
        }
        else{            
            Console.WriteLine("Amount due: " + PriceOfTicket+ "GHC");
        }
        break;
    }
}


Thread.Sleep(5000);
Environment.Exit(0);
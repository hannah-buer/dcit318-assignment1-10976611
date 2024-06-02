int score;
while (true)
{
    Console.WriteLine("Enter score between 0 to 100: ");
    if (!int.TryParse(Console.ReadLine(), out score))
    {
        Console.WriteLine("Please enter a valid integer score. ");
        continue;
    }
     
    if(score < 0 || score > 100){
        Console.WriteLine("Please enter a score between 0 and 100. ");
        continue;
    }
    if (score >= 0 && score <= 100){
        if (score > 89){
            Console.WriteLine("A");
        } 
        else if (score > 79){
            Console.WriteLine("B");
        }
        else if (score > 69){
            Console.WriteLine("C");        
        }
        else if (score > 59){
            Console.WriteLine("D");
        }
        else{
            Console.WriteLine("F");
        }
        break;
    }

}


Thread.Sleep(5000);
Environment.Exit(0);
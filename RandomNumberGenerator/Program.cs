Console.WriteLine("Whats your min value?");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("whats your max value?");
int max = int.Parse(Console.ReadLine());
Random randomGenerator= new Random();               //random number generator
int randomNumber = randomGenerator.Next(min, max); // ^
Console.WriteLine("Guess the number!");
while (true)
{
    int guess = int.Parse(Console.ReadLine());
    if (guess == randomNumber)
    {
        Console.WriteLine("Correct");
        break;
    } 
    else if (guess > randomNumber)
    {
        Console.WriteLine("The number is smaller, try again");
    }
    else if (guess < randomNumber)
    {
        Console.WriteLine("The number is bigger, try again");
    }
        
}

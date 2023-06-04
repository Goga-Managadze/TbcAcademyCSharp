// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter paper, stone or scissors");
var input = Console.ReadLine();
Random rnd = new Random();
string[] things = { "paper", "stone", "scissors" };
int index = rnd.Next(things.Length);

if (input == things[index])
{
    Console.WriteLine("Draw");
    Console.WriteLine("Your Answer was " + input);
    Console.WriteLine("The application choice was " + things[index]);
}
else if ((input == things[0] && things[index] == "scissors") || (input == things[1] && things[index] == "paper") || input == things[2] && things[index] == "stone")
{
    Console.WriteLine("The application won");
    Console.WriteLine("Your Answer was " + input);
    Console.WriteLine("The application choice was " + things[index]);
}
else if (input == things[2] && things[index] == "paper" || (input == things[0] && things[index] == "stone") || input == things[1] && things[index] == "scissors")
{
    Console.WriteLine("You won");
    Console.WriteLine("Your Answer was " + input);
    Console.WriteLine("The application choice was " + things[index]);
}
else
{
    Console.WriteLine("Your input wasn't paper, stone or scissors");
}

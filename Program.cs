using System;

Console.WriteLine("Guess The SECRET Number!");
Console.WriteLine("------------------------");
Console.WriteLine();

Random r = new Random();
int SecretNumber = r.Next(1, 100);


int AllowedTries = 4;
int NumberOfTries = 0;
int H = AllowedTries;
int M = AllowedTries + 2;
int E = AllowedTries + 4;


Console.WriteLine("Choose your Difficulty: E-Easy, M-Medium, H-Hard");

while (true)
{
    string MyChoice = Console.ReadLine();
    if (H == Int32.Parse(MyChoice))
    {
        Console.WriteLine("You Chose Hard");
    }
    if (M == Int32.Parse(MyChoice))
    {
        Console.WriteLine("You Chose Medium");
    }
    if (E == Int32.Parse(MyChoice))
    {
        Console.WriteLine("You Chose Easy");
    }
    break;
}

while (true)
{
    NumberOfTries++;
    string MyGuess = Console.ReadLine();


    if (SecretNumber == Int32.Parse(MyGuess))
    {
        Console.WriteLine("You guessed Right!!!");
        break;
    }
    if (SecretNumber < Int32.Parse(MyGuess))
    {
        Console.WriteLine($"Too high. Try again. You guessed, {MyGuess} and you have {AllowedTries - NumberOfTries} tries left.");
    }
    if (SecretNumber > Int32.Parse(MyGuess))
    {
        Console.WriteLine($"Too low. Try again. You guessed, {MyGuess} and you have {AllowedTries - NumberOfTries} tries left.");
    }
    if (NumberOfTries == AllowedTries)
    {
        Console.WriteLine($"Out of Guesses, the correct number was {SecretNumber}");
        break;
    }

}

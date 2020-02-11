using System;

namespace RockPaperScissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Rock, Paper, Scissors!");
      Console.WriteLine("Please choose one of the following: rock, paper or scissors");

      var userChoice = Console.ReadLine().ToLower();
      if (userChoice != "rock" && userChoice != "paper" && userChoice != "scissors")
      {
        Console.WriteLine("That is not a valid response, try running the game again...");
      }
      else
      {
        Console.WriteLine("You chose " + userChoice);
        Console.WriteLine("Let's see what your opponent chooses...");

        var randomPick = new Random();
        string[] options = { "rock", "paper", "scissors" };

        // Create a random object

        int index = randomPick.Next(options.Length);
        //index is a number (int)
        Console.WriteLine("Your opponent chose " + options[index]);
        var computerChoice = options[index];

        //ROCK
        if (userChoice == "rock" && computerChoice == "scissors")
        {
          Console.WriteLine("You win! ROCK CRUSHES SCISSORS!");
        }
        else if (userChoice == "rock" && computerChoice == "paper")
        {
          Console.WriteLine("Your opponent won! PAPER COVERS ROCK!");
        }
        else if (userChoice == "rock" && computerChoice == "rock")
        {
          Console.WriteLine("It's a draw!");
        }
        //PAPER
        if (userChoice == "paper" && computerChoice == "rock")
        {
          Console.WriteLine("You win! PAPER COVERS ROCK!");
        }
        else if (userChoice == "paper" && computerChoice == "scissors")
        {
          Console.WriteLine("Your opponent won! SCISSORS CUT PAPER!");
        }
        else if (userChoice == "paper" && computerChoice == "paper")
        {
          Console.WriteLine("It's a draw!");
        }
        //SCISSORS
        if (userChoice == "scissors" && computerChoice == "paper")
        {
          Console.WriteLine("You win! SCISSORS CUT PAPER!");
        }
        else if (userChoice == "scissors" && computerChoice == "rock")
        {
          Console.WriteLine("Your opponent won! ROCK CRUSHES SCISSORS!");
        }
        else if (userChoice == "scissors" && computerChoice == "scissors")
        {
          Console.WriteLine("It's a draw!");
        }
      }



    }
  }
}

using System;
namespace Github
{
    public class RockPaper
    {
        public static string DetermineWinner(string player1Choice, string player2Choice)
        {
            // Normalize inputs to lowercase
            player1Choice = player1Choice.ToLower();
            player2Choice = player2Choice.ToLower();

            // Validate choices
            string[] validChoices = { "rock", "paper", "scissors" };
            if (Array.IndexOf(validChoices, player1Choice) == -1 || Array.IndexOf(validChoices, player2Choice) == -1)
            {
                return "Invalid choice. Please choose Rock, Paper, or Scissors.";
            }

            // Determine winner using nested conditionals
            if (player1Choice == player2Choice)
            {
                return "It's a tie!";
            }
            else if (player1Choice == "rock")
            {
                if (player2Choice == "scissors")
                {
                    return "Player 1 wins! Rock crushes Scissors.";
                }
                else // player2Choice == "paper"
                {
                    return "Player 2 wins! Paper covers Rock.";
                }
            }
            else if (player1Choice == "paper")
            {
                if (player2Choice == "rock")
                {
                    return "Player 1 wins! Paper covers Rock.";
                }
                else // player2Choice == "scissors"
                {
                    return "Player 2 wins! Scissors cut Paper.";
                }
            }
            else // player1Choice == "scissors"
            {
                if (player2Choice == "paper")
                {
                    return "Player 1 wins! Scissors cut Paper.";
                }
                else // player2Choice == "rock"
                {
                    return "Player 2 wins! Rock crushes Scissors.";
                }
            }
        }
    }
}
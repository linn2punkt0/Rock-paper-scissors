using System;
using System.Collections.Generic;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGame();
        }

        private static void PlayGame()
        {
            Console.WriteLine("Time to play Rock, Paper, Scissors!");
            string playersOption = "";
            string computersOption = "";
            Console.WriteLine("Choose your weapon, type: 'Rock', 'Paper' or 'Scissors'.");
            string readInput = Console.ReadLine();
            string lowercaseInput = readInput.ToLower();
            playersOption = char.ToUpper(lowercaseInput[0]) + lowercaseInput.Substring(1);

            while (CheckUserInput(playersOption) == false)
            {
                Console.WriteLine("Invalid weapon, we only play with 'Rock', 'Paper' or 'Scissors' here.");
                Console.WriteLine("Choose your weapon, type: 'Rock', 'Paper' or 'Scissors'.");
                playersOption = Console.ReadLine();
            }
            Console.WriteLine($"You chose {playersOption}.");
            computersOption = ComputersChoice();
            CompareOptions(playersOption, computersOption); 
            Console.WriteLine();
            PlayAgain();
        }

        private static List<string> optionList = new List<string>(){"Rock", "Paper", "Scissors"} ;
        
        private static bool CheckUserInput(string input)
        {
            if ( optionList.Contains(input) )
            {
                return true;
            }
            
            else
            {
                return false;
            }
        }

        private static string ComputersChoice()
        {
            Random rnd = new Random();
            int r = rnd.Next(optionList.Count);
            return optionList[r]; 
        }

        private static void CompareOptions(string player, string computer)
        {
            if (computer == player)
            {
                Console.WriteLine($"Computer chose {computer}.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("It's a tie!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (computer == "Rock")
            {
                if (player == "Scissors")
                {
                    Console.WriteLine($"Computer chose {computer}.");
                    LoserMessage();
                }

                if (player == "Paper")
                {
                    Console.WriteLine($"Computer chose {computer}.");
                    WinnerMessage();
                }
            }
            
            if (computer == "Paper")
            {
                if (player == "Rock")
                {
                    Console.WriteLine($"Computer chose {computer}.");
                    LoserMessage();
                }

                if (player == "Scissors")
                {
                    Console.WriteLine($"Computer chose {computer}.");
                    WinnerMessage();
                }
            }
            
            if (computer == "Scissors")
            {
                if (player == "Paper")
                {
                    Console.WriteLine($"Computer chose {computer}.");
                    LoserMessage();
                }
                if (player == "Rock")
                {
                    Console.WriteLine($"Computer chose {computer}.");
                    WinnerMessage();
                }
            }
        }

        private static void PlayAgain()
        {
            Console.WriteLine("Play again? Press the spacebar.");
            if (Console.ReadKey(true).Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine();
                PlayGame();
            }
        }

        private static void WinnerMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You won!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void LoserMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Computer won, you loose.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
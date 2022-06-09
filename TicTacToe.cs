using System;
using System.Collections.Generic;

namespace Week1
{
    internal class TicTacToe
    {
        static void Main(string[] args)
        {

            // Initialize the settings
            bool gameOver = false;
            string gameOverMessage = "Game not yet over";


            // Initialize the board
            List<string> squares = new List<string>();
            for (int i = 1; i < 10; i++)
            {
                string initValue = i.ToString();
                squares.Add(initValue);
            }


            // Initialize the player
            string player = "X";


            // Start the game
            do
            {
                // Draw the board
                Console.WriteLine($"{squares[0]}|{squares[1]}|{squares[2]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{squares[3]}|{squares[4]}|{squares[5]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{squares[6]}|{squares[7]}|{squares[8]}");




                // Switch player
                if (player == "X")
                {
                    player = "O";
                }
                else
                {
                    player = "X";
                }


                // Create win state






                // Create tie state
                foreach (string square in squares)
                {
                    if (square == "X" | square == "O")
                    {
                        gameOver = true;
                        gameOverMessage = "Game over. It's a draw!";
                    }
                }


                // If the game isn't over...
                if (!(gameOver))
                {

                    // Display player turn and get user choice
                    Console.Write($"{player}'s turn to choose a square (1-9): ");
                    string userChoice = Console.ReadLine();
                    int chosenSquare = int.Parse(userChoice);


                    // 


                }
                

            } while (!(gameOver));

            Console.WriteLine(gameOverMessage);

            


        }
    }
}
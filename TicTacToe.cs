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
            bool squareFilled = false;
            bool changePlayer = true;
            bool won = false;


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
                Console.WriteLine();
                Console.WriteLine($"{squares[0]}|{squares[1]}|{squares[2]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{squares[3]}|{squares[4]}|{squares[5]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{squares[6]}|{squares[7]}|{squares[8]}");
                Console.WriteLine();




                // Switch player
                if (changePlayer)
                {
                    if (player == "X")
                    {
                        player = "O";
                    }
                    else
                    {
                        player = "X";
                    }
                }
                


                // Create win state






                // Create tie state
                if (!(won))
                {
                    do
                    {
                        int i = 0;
                        if (i <= 8)
                        {
                            if (!(squares[i] == "X" | squares[i] == "O"))
                            {
                                squareFilled = false;
                            }
                            i += 1;
                        }
                        else
                        {
                            gameOverMessage = "Game over. It was a draw!";
                        }
                        
                    } while (squareFilled);
                }
                


                // If the game isn't over...
                if (!(gameOver))
                {

                    // Display player turn and get user choice
                    Console.Write($"{player}'s turn to choose a square (1-9): ");
                    string userChoice = Console.ReadLine();
                    int chosenSquare = int.Parse(userChoice);


                    // Update the board
                    if (squares[chosenSquare - 1] == "X" | squares[chosenSquare - 1] == "O")
                    {
                        Console.WriteLine("That square is taken already. Choose again.");
                        changePlayer = false;
                    }
                    else
                    {
                        squares[chosenSquare - 1] = player;
                        changePlayer = true;
                    }

                }
                

            } while (!(gameOver));

            Console.WriteLine(gameOverMessage);

            


        }
    }
}
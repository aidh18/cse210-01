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
            bool boardFilled = false;
            bool changePlayer = true;
            bool hasEmptySquare = true;
            bool continueLoop = true;


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


                // Create win state if the game is not already over
                if (!(gameOver))
                {

                    // Check 1st row
                    if ((squares[0] == squares[1]) & (squares[1] == squares[2]))
                    {
                        gameOver = true;
                        gameOverMessage = $"{player} wins!";
                        changePlayer = false;
                    }

                    // Check 2nd row
                    else if ((squares[3] == squares[4]) & (squares[4] == squares[5]))
                    {
                        gameOver = true;
                        gameOverMessage = $"{player} wins!";
                        changePlayer = false;
                    }

                    // Check 3rd row
                    else if ((squares[6] == squares[7]) & (squares[7] == squares[8]))
                    {
                        gameOver = true;
                        gameOverMessage = $"{player} wins!";
                        changePlayer = false;
                    }

                    // Check 1st column
                    else if ((squares[0] == squares[3]) & (squares[3] == squares[6]))
                    {
                        gameOver = true;
                        gameOverMessage = $"{player} wins!";
                        changePlayer = false;
                    }

                    // Check 2nd column
                    else if ((squares[1] == squares[4]) & (squares[4] == squares[7]))
                    {
                        gameOver = true;
                        gameOverMessage = $"{player} wins!";
                        changePlayer = false;
                    }

                    // Check 3rd column
                    else if ((squares[2] == squares[5]) & (squares[5] == squares[8]))
                    {
                        gameOver = true;
                        gameOverMessage = $"{player} wins!";
                        changePlayer = false;
                    }

                    // Check top left to bottom right diagonal
                    else if ((squares[0] == squares[4]) & (squares[4] == squares[8]))
                    {
                        gameOver = true;
                        gameOverMessage = $"{player} wins!";
                        changePlayer = false;
                    }

                    // Check bottom left to top right diagonal
                    else if ((squares[6] == squares[4]) & (squares[4] == squares[2]))
                    {
                        gameOver = true;
                        gameOverMessage = $"{player} wins!";
                        changePlayer = false;
                    }

                }


                // Create tie state if game is not already over
                if (!(gameOver))
                {
                    int i = 0;
                    do
                    {
                        // Iterates through each square on the board until it finds
                        // an empty space.
                        if (i <= 8)
                        {
                            if (squares[i] == "X" | squares[i] == "O")
                            {
                                i += 1;
                                hasEmptySquare = false;
                                continueLoop = true;
                            }
                            // If there is an empty space, the game can continue 
                            // for at least one more turn.
                            else
                            {
                                hasEmptySquare = true;
                                boardFilled = false;
                                continueLoop = false;
                            }
                        }
                        // If there are no empty squares and it has iterated through
                        // each square already, end the game and return a "tied"
                        // message. 
                        else
                        {
                            boardFilled = true;
                            hasEmptySquare = false;
                            gameOver = true;
                            gameOverMessage = "Game over. It was a draw!";
                            continueLoop = false;
                        }
                        
                    } while (continueLoop);
                }
                

                // If the game isn't over, new turn!
                if (!(gameOver))
                {

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
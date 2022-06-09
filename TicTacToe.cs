using System;
using System.Collections.Generic;

namespace Week1
{
    internal class TicTacToe
    {
        // Main Function
        static void Main(string[] args)
        {

            // Initialize the settings
            bool gameOver = false;
            string gameOverMessage = "Game not yet over";
            bool changePlayer = true;


            // Initialize the board
            List<string> squares = SquaresList();


            // Initialize the player
            string player = "O";


            // Start the game
            do
            {
                
                // Draw the board
                drawBoard(squares);


                // Check and return a win state if game is won
                bool hasWon = checkForWin(squares);


                // If there is a win, end the game
                if (hasWon)
                {
                    gameOver = true;
                    gameOverMessage = $"Game over. {player} wins!";
                }


                 // Check and return a win state if game is won
                bool hasDrawn = checkForDraw(squares);


                // If there is a draw, end the game
                if (hasDrawn & (!(hasWon)))
                {
                    gameOver = true;
                    gameOverMessage = "Game over. It was a draw!";
                }
                

                // If the game isn't over, new turn!
                if (!(gameOver))
                {

                    // Switch player
                    player = switchPlayer(changePlayer, player);


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



        // Function that creates and returns a list of values that each correspond
        // to a square
        static List<string> SquaresList()
        {  
            List<string> squares = new List<string>();
            for (int i = 1; i < 10; i++)
            {
                string initValue = i.ToString();
                squares.Add(initValue);
            }
            
            return squares;
        }



        // Function that draws the board
        static void drawBoard(List<string> squares)
        {

            Console.WriteLine();
            Console.WriteLine($"{squares[0]}|{squares[1]}|{squares[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{squares[3]}|{squares[4]}|{squares[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{squares[6]}|{squares[7]}|{squares[8]}");
            Console.WriteLine();

        }



        // Function that checks if there is a tie
        static bool checkForDraw(List<string> squares)
        {

            bool continueLoop = true;
            bool draw = false;
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
                        continueLoop = true;
                    }
                    // If there is an empty space, the game can continue 
                    // for at least one more turn.
                    else
                    {
                        continueLoop = false;
                        draw = false;
                    }
                }
                // If there are no empty squares and it has iterated through
                // each square already, end the game and return a "tied"
                // message. 
                else
                {
                    draw = true;
                    continueLoop = false;
                }
                
            } while (continueLoop);

            return draw;
        }



        // Function that changes the player
        static string switchPlayer(bool changePlayer, string player)
        {
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
            
            return player;
        }



        // Function that checks if a player has won
        static bool checkForWin(List<string> squares)
        {

            bool won = false;

            // Check 1st row
            if ((squares[0] == squares[1]) & (squares[1] == squares[2]))
            {
                won = true;
            }

            // Check 2nd row
            else if ((squares[3] == squares[4]) & (squares[4] == squares[5]))
            {
                won = true;
            }

            // Check 3rd row
            else if ((squares[6] == squares[7]) & (squares[7] == squares[8]))
            {
                won = true;
            }

            // Check 1st column
            else if ((squares[0] == squares[3]) & (squares[3] == squares[6]))
            {
                won = true;
            }

            // Check 2nd column
            else if ((squares[1] == squares[4]) & (squares[4] == squares[7]))
            {
                won = true;
            }

            // Check 3rd column
            else if ((squares[2] == squares[5]) & (squares[5] == squares[8]))
            {
                won = true;
            }

            // Check top left to bottom right diagonal
            else if ((squares[0] == squares[4]) & (squares[4] == squares[8]))
            {
                won = true;
            }

            // Check bottom left to top right diagonal
            else if ((squares[6] == squares[4]) & (squares[4] == squares[2]))
            {
                won = true;
            }

            return won;

        }


    }
}
using System;
using System.Collections.Generic;

namespace Week1
{
    internal class TicTacToe
    {
        static void Main(string[] args)
        {

            List<string> squares = new List<string>();

            for (int i = 1; i < 10; i++)
            {
                string initValue = i.ToString();
                squares.Add(initValue);
            }


            Console.WriteLine($"{squares[0]}|{squares[1]}|{squares[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{squares[3]}|{squares[4]}|{squares[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{squares[6]}|{squares[7]}|{squares[8]}");

        }
    }
}
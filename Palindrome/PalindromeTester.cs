//  --------------------------------------------------------------------------------------------------------------------
//     <copyright file="PalindromeTester.cs">
//         Copyright (c) Nathan Bowman. All rights reserved.
//         Licensed under the MIT License. See LICENSE file in the project root for full license information.
//     </copyright>
//  --------------------------------------------------------------------------------------------------------------------
namespace Palindrome
{
    using System;

    /// <summary>
    /// </summary>
    internal class PalindromeTester
    {
        private const ConsoleColor BACKGROUNDCOLOUR = ConsoleColor.Blue;

        private const ConsoleColor FOREGROUNDCOLOUR = ConsoleColor.White;

        private static void ClearInputBuffer()
        {
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }
        }

        private static void Main(string[] args)
        {
            Console.Title = "Palindrome Testing Application";
            while (true)
            {
                Console.Clear();
                Console.CursorVisible = false;
                ClearInputBuffer();

                var playerInput = Question("Input a word, sentence or number and I will tell you if it is a palindrome!");
                SetConsoleColoursAndWrite($"\"{playerInput}\" is {(playerInput.IsPalindrome() ? "" : "not")} a palindrome.\nPress any key to restart, or 'Escape' to Exit");
                var keyPressed = Console.ReadKey().Key;
                if (keyPressed == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }

        private static string Question(string question)
        {
            SetConsoleColoursAndWrite(question);
            ClearInputBuffer();
            Console.CursorVisible = true;
            var answer = Console.ReadLine();
            ;
            Console.CursorVisible = false;
            return answer;
        }

        /// <summary>
        ///     Change console colours to the output colours and write to the console
        /// </summary>
        /// <param name="outputString">String to write to the console</param>
        private static void SetConsoleColoursAndWrite(string outputString)
        {
            Console.BackgroundColor = BACKGROUNDCOLOUR;
            Console.ForegroundColor = FOREGROUNDCOLOUR;
            Console.WriteLine(outputString);
            Console.ResetColor();
        }
    }
}
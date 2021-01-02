using System;
using System.Linq;

namespace ForMyself
{
    class Program
    {
        static void Main(string[] args)
        {
            HangmanGame game = new HangmanGame();

            string word = game.GenerateWord();

            Console.WriteLine($"The word consists of {word.Length} letters.");

            Console.WriteLine("Try to guess the word.");

            while (game.gameStatus == GameStatus.InProgress)
            {
                Console.WriteLine("Pick a letter");

                char c = (char)Console.ReadLine().ToCharArray()[0];

                string cursState = game.GuessLetter(c);
                Console.WriteLine(cursState);

                Console.WriteLine($"Remaining tries = {game.RemainingTrise}");

                Console.WriteLine($"Tried letters: {game.TriedLetters}");
            }
            if (game.gameStatus == GameStatus.Lost)
            {
                Console.WriteLine("You're hanged");
                Console.WriteLine($"The word was: {game.Word}");
            }
            else if(game.gameStatus == GameStatus.Won)
            {
                Console.WriteLine("You're won!");
            }
            Console.ReadLine();
        }


        
    }
}

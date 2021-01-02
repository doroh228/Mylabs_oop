using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ForMyself
{

    class HangmanGame
    {
        

        private readonly int _allowedMisses;
        private bool[] _openIndexes;
        private int _triesCounter = 0;
        private string _triedLetters;

        public GameStatus gameStatus = GameStatus.NotStarted;

        public string Word { get; private set; }

        public string TriedLetters
        {
            get
            {
                var chars = _triedLetters.ToCharArray();
                Array.Sort(chars);
                return new string(chars);
            }
        }

        public int RemainingTrise
        {
            get
            {
                return _allowedMisses - _triesCounter;
            }
        }

        public HangmanGame(int allowedMisses = 6)
        {
            if(allowedMisses <2 || allowedMisses > 10)
            {
                throw new ArgumentException("Number of allowed misses should be between 2 and 10");
            }
            this._allowedMisses = allowedMisses;

        }

        public string GenerateWord()
        {
            string[] words = File.ReadAllLines("WordsStockRus.txt");
            Random r = new Random(DateTime.Now.Millisecond);

            Word =  words[r.Next(words.Length - 2)];

            _openIndexes = new bool[Word.Length];

            gameStatus = GameStatus.InProgress;

            return Word;
        }

        public string GuessLetter(char letter)
        {
            if(_triesCounter == _allowedMisses)
            {
                throw new InvalidOperationException("End");
            }
            if (gameStatus != GameStatus.InProgress)
            {
                throw new InvalidOperationException("invalide");
            }

            bool openAnyLatters = false;

            string result = string.Empty;

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == letter)
                {
                    _openIndexes[i] = true;
                    openAnyLatters = true;
                }
                if (_openIndexes[i])
                {
                    result += Word[i];
                }
                else
                {
                    result += "-";
                }
            }
                if (!openAnyLatters)
                {
                    _triesCounter++;
                }

                _triedLetters += letter;

                if (IsWin())
                {
                    gameStatus = GameStatus.Won;
                }
                else if(_triesCounter == _allowedMisses)
                {
                    gameStatus = GameStatus.Lost;
                }
            
            return result;
        }

        private bool IsWin()
        {
            foreach (var cut in _openIndexes)
            {
                if (cut == false)
                {
                    return false;
                }
            }
            return true;
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;

namespace Anagram
{


    public class AnagramProgram
    {
        private string _wordOne;
        private List<string> _listOfWords = new List<string>() { };


        public void SetWordOne(string word)
        {
            _wordOne = word;
        }

        public string GetWordOne()
        {
            return _wordOne;
        }

        public void SetListOfWords(string word)
        {
            _listOfWords.Add(word);
        }

        public List<string> GetListOfWords()
        {
            return _listOfWords;
        }

        public void StartGame()
        {
            Console.WriteLine("Enter a word:");
            SetWordOne(Console.ReadLine());

            Console.WriteLine("Enter a list of words to see if they match:");
            GetInputForList();
        }

        public void GetInputForList()
        {
            string[] inputList = Console.ReadLine().Split(' ');
            CompileList(inputList);
        }

        public void CompileList(string[] listOfWords)
        {
            foreach (string word in listOfWords)
            {
                SetListOfWords(word);
            }



            //foreach (string word in GetListOfWords())
            //{
            //    Console.WriteLine(word);
            //}
        }




    }


    class Program
    {
        


        static void Main(string[] args)
        {
            AnagramProgram newGame = new AnagramProgram();
            newGame.StartGame();






    

        }
    }
}

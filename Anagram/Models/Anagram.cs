using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Anagram.Models
{


    public class AnagramProgram
    {
     

        private string _word1;
        private string _word2;
        private string[] _wordArray;
        private string _match;

        //public static List<string> MatchesList = new List<string>();

        public void SetWord1(string word)
        {
            _word1 = word;
        }

        public string GetWord1()
        {
            return _word1;
        }

        public void SetWord2(string word)
        {
            _word2 = word;
        }

        public string GetWord2()
        {
            return _word2;
        }

        public void  SetWordArray(string[] words)
        {
            _wordArray = words;
        }

        public string[] GetWordArray()
        {
            return _wordArray;
        }

        public void SetMatch(string match)
        {
            _match = match;
        }

        public string GetMatch()
        {
            return _match;
        }

        public string[] SplitString(string words)
        {
            string[] listArray = words.Split();
            SetWordArray(listArray);
            return GetWordArray();

        }

        public char[] SortString(string toSort)
        {
            char[] charToSort = toSort.ToCharArray();
            Array.Sort(charToSort);
            return charToSort;
        }

       

        public List<string> Compare(string[] wordArray)
        {
            List<string> MatchesList = new List<string>();

            string input = "save";
            foreach (string word in wordArray)
              
            {
                if (SortString(word) == SortString(input))
                    MatchesList.Add(word);
            }
            Console.WriteLine(MatchesList);
            return MatchesList;
                
        }



    }
}

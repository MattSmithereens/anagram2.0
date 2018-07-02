using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Anagram.Models
{


    public class AnagramProgram
    {
        //private List<string> _listOfWords = new List<string>() { };

        private string _word1;
        private string _word2;

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

        //public void SetListOfWords(string word)
        //{
        //    _listOfWords.Add(word);
        //}

        //public List<string> GetListOfWords()
        //{
        //    return _listOfWords;
        //}

        //public void StartGame()
        //{
        //    Console.WriteLine("Enter a word:");
        //    SetWordOne(Console.ReadLine());

        //    Console.WriteLine("Enter a list of words to see if they match:");
        //    GetInputForList();
        //}

        //public void GetInputForList()
        //{
        //    string[] inputList = Console.ReadLine().Split(' ');
        //    CompileList(inputList);
        //}

        //public void CompileList(string[] listOfWords)
        //{
            //foreach (string word in listOfWords)
            //{
            //    SetListOfWords(word);
            //}



            //foreach (string word in GetListOfWords())
            //{
            //    Console.WriteLine(word);
            //}
        }
    }

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram;
using System;

namespace Anagram.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetSetUserWords_GetsSetsUserWords_StringList()
        {
            AnagramProgram TestAnagram = new AnagramProgram();
            string testWord = "test";
            TestAnagram.SetWordOne(testWord);
            Assert.AreEqual(testWord, TestAnagram.GetWordOne());
        }

        [TestMethod]
        public void GetSetListWords_GetsSetsListWords_StringList()
        {
            AnagramProgram TestAnagram = new AnagramProgram();
            string testWords = "test test test";
            TestAnagram.SetListOfWords(testWords);
            Assert.AreEqual(testWords, TestAnagram.GetListOfWords()[0]);
        }

        [TestMethod]
        public void CompileList_WillCompileList_StringList()
        {
            AnagramProgram TestAnagram = new AnagramProgram();
            List<string> testList = new List<string>(new string[] { "bob", "gary", "mike" });
            string word = "bob gary mike";
            string[] inputList = word.Split(' ');
            CollectionAssert.AreEqual(testList, TestAnagram.GetInputForList(word));
        }

        [TestMethod]
        public void SplitList_WillSplitandSort_StringList()
        {
            AnagramProgram TestAnagram = new AnagramProgram();
            string name = "apple";
            char[] testString = {'a','e','l','p','p'};
            CollectionAssert.AreEqual(testString, TestAnagram.SplitWordList(name));
        }

        [TestMethod]
        public void CompareSortedWords_WillReturnBool_CompareWords()
        {
            AnagramProgram TestAnagram = new AnagramProgram();
            string testword = "save";
            string testword2 = "vase";
            char[] testString = { 'a', 'e', 's', 'v'};
            TestAnagram.GetWordOne(testString);
            char[] testChar = TestAnagram.SplitWordList(testword);
            char[] testChar2 = TestAnagram.SplitWordList(testword2);
            CollectionAssert.AreEqual(true, TestAnagram.CompareWords(testChar2));
        }
    
    
    }
}

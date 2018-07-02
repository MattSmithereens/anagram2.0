using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram.Tests
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void GetSetUserWords_GetsSetsUserWords_StringList()
        //{
        //    AnagramProgram TestAnagram = new AnagramProgram();
        //    string testWord = "test";
        //    TestAnagram.SetWordOne(testWord);
        //    Assert.AreEqual(testWord, TestAnagram.GetWordOne());
        //}

        //[TestMethod]
        //public void GetSetListWords_GetsSetsListWords_StringList()
        //{
        //    AnagramProgram TestAnagram = new AnagramProgram();
        //    string testWords = "test test test";
        //    TestAnagram.SetListOfWords(testWords);
        //    Assert.AreEqual(testWords, TestAnagram.GetListOfWords()[0]);
        //}

        [TestMethod]
        public void SplitList_WillCompileList_StringList()
        {
            AnagramProgram TestAnagram = new AnagramProgram();
            string[] testList =  { "bob", "gary", "mike" };
            string word = "bob gary mike";
            CollectionAssert.AreEqual(testList, TestAnagram.SplitString(word));
        }

        [TestMethod]
        public void SplitList_WillSplitandSort_StringList()
        {
            AnagramProgram TestAnagram = new AnagramProgram();
            string name = "apple";
            char[] testString = {'a','e','l','p','p'};
            CollectionAssert.AreEqual(testString, TestAnagram.SortString(name));
        }

        [TestMethod]
        public void CompareSortedWords_WillReturnBool_CompareWords()
        {
            AnagramProgram TestAnagram = new AnagramProgram();
            TestAnagram.SetWord1("save");
            var tempList = new List<string> { "vase"};
            string[] testArray = { " vase", " ghost", " apple" };
            CollectionAssert.AreEqual(tempList, TestAnagram.Compare(testArray));
        }
    
    
    }
}

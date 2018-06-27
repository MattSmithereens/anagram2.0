using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram;

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
            List<string> testList = new List<string>(new string[] { "a", "b", "c" });
            string word = "a b c";
            string[] inputList = word.Split(' ');
            TestAnagram.CompileList(inputList);
            CollectionAssert.AreEqual(testList, TestAnagram.GetListOfWords());
        }
    }
}

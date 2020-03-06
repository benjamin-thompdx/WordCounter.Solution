using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace Wordcounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void GetSentenceArray_GetUserSentenceAndConvertToArray_Array()
    {
      //Arrange
      string userSentence = "the quick brown fox jumps over the lazy dog";
      //Act
      string[] sentenceArr = RepeatCounter.GetSentenceArray(userSentence);
      //Assert
      Assert.AreEqual("the", sentenceArr[0]);
    }

    [TestMethod]
    public void GetWord_GetUserWord_String()
    {
      //Arrange
      string userWord = "the";
      //Act
      string word = RepeatCounter.GetWord(userWord);
      //Assert
      Assert.AreEqual("quick", word);
    }
  }
}
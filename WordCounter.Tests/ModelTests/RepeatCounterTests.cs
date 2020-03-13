using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace Wordcounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    RepeatCounter testRepeatCounter = new RepeatCounter("the quick brown fox jumps over the lazy dog", "the");

    // [TestMethod]
    // public void GetSentence_GetUserSentence_String()
    // {
    //   //Arrange
    //   string userSentence = "the quick brown fox jumps over the lazy dog";
    //   //Act
    //   string sentence = RepeatCounter.GetSentence(userSentence);
    //   //Assert
    //   Assert.AreEqual("the quick brown fox jumps over the lazy dog", sentence);
    // }

    // [TestMethod]
    // public void GetSentenceArray_GetUserSentenceAndConvertToArray_Arr()
    // {
    //   //Arrange
    //   string userSentence = "the quick brown fox jumps over the lazy dog";
    //   //Act
    //   string[] sentenceArr = RepeatCounter.GetSentenceArray(userSentence);
    //   //Assert
    //   Assert.AreEqual("the", sentenceArr[0]);
    // }

    // [TestMethod]
    // public void GetWord_GetUserWord_String()
    // {
    //   //Arrange
    //   string userWord = "the";
    //   //Act
    //   string word = RepeatCounter.GetWord(userWord);
    //   //Assert
    //   Assert.AreEqual("the", word);
    // }

    [TestMethod]
    public void GetRepeatWordFrequency_GetUserWordFrequencyFromUserSentence_Int()
    {
      //Arrange
      string[] sentenceArr = { "the", "them", "they", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
      //Act
      int frequency = testRepeatCounter.GetRepeatWordFrequency();
      //Assert
      Assert.AreEqual(2, frequency);
    }
  }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace Wordcounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {

    [TestMethod]
    public void GetSentence_GetUserSentence_String()
    {

      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter("the quick brown fox jumps over the lazy dog", "the");
      //Act
      string sentence = RepeatCounter.GetSentence(testRepeatCounter.Sentence);
      //Assert
      Assert.AreEqual("the quick brown fox jumps over the lazy dog", sentence);
    }

    [TestMethod]
    public void GetSentenceArray_GetUserSentenceAndConvertToArray_Arr()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter("the quick brown fox jumps over the lazy dog", "the");
      //Act
      string[] sentenceArr = RepeatCounter.GetSentenceArray(testRepeatCounter.Sentence);
      //Assert
      Assert.AreEqual("the", sentenceArr[0]);
    }

    [TestMethod]
    public void GetWord_GetUserWord_String()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter("the quick brown fox jumps over the lazy dog", "the");
      //Act
      string word = RepeatCounter.GetWord(testRepeatCounter.Word);
      //Assert
      Assert.AreEqual("the", word);
    }

    [TestMethod]
    public void GetRepeatWordFrequency_GetUserWordFrequencyFromUserSentence_Int()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter("the quick brown fox jumps over the lazy dog", "the");
      string[] sentenceArr = { "the", "them", "they", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
      //Act
      int frequency = testRepeatCounter.GetRepeatWordFrequency();
      //Assert
      Assert.AreEqual(2, frequency);
    }
  }
}

    public RepeatCounterTests(string userSentece, string userWord)
    {
      userSentece = "the quick brown fox jumps over the lazy dog";
      userWord = "the";
    }
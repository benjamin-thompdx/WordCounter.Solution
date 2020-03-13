using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace Wordcounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
    RepeatCounter testRepeatCounter = new RepeatCounter("the quick brown fox jumps over the lazy dog", "the");
    
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
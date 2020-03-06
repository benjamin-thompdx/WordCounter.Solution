using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string[] SentenceArr { get; set; }
    public string Word { get; set; }

    public static string GetSentence(string userSentence)
    {
      string sentence = userSentence;
      return sentence;
    }
    
    public static string[] GetSentenceArray(string userSentence)
    {
      string[] sentenceArr = userSentence.Split(' ');
      return sentenceArr;
    }

    public static string GetWord(string userWord)
    {
      string word = userWord;
      return word;
    }

    public static int GetRepeatWordFrequency(string[] sentenceArr, string word)
    {
      int frequency = 0;

      for (int i = 0; i < sentenceArr.Length; i++)
      if (word.Equals(sentenceArr[i]))
      {
        frequency++;
      }
      return frequency;
    }
  }
}
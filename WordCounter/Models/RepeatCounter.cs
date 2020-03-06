using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string[] SentenceArr { get; set; }
    public string Word { get; set; }
    
    public static string[] GetSentenceArray(string userSentence)
    {
      // userSentence = "the quick brown fox jumps over the lazy dog";
      string[] sentenceArr = userSentence.Split(' ');
      return sentenceArr;
    }

    public static string GetWord(string userWord)
    {
      string word = userWord;
      return word;
    }

    // static int search(string[] sentenceArr, string word)
    // {
    //   int counter = 0;

    //   for (int i = 0; i < sentenceArr.Length; i++)
    //   if (word.Equals(sentenceArr[i]))
    //   {
    //     counter++;
    //     return counter;
    //   }
    // }
  }
}
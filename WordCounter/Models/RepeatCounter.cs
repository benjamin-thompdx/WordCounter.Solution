namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public string Sentence { get; set; }
    public string[] SentenceArr { get; set; }
    public string Word {get; set; }

    public RepeatCounter(string sentence, string word)
    {
      Sentence = sentence;
      SentenceArr = Sentence.Split(' ');
      Word = word;
    }


    // public string GetSentence()
    // {
    //   string sentence = userSentence;
    //   return sentence;
    // }
    
    // public string[] GetSentenceArray(string userSentence)
    // {
    //   string[] sentenceArr = userSentence.Split(' ');
    //   return sentenceArr;
    // }

    // public string GetWord(string userWord)
    // {
    //   string word = userWord;
    //   return word;
    // }

    public int GetRepeatWordFrequency()
    {
      int frequency = 0;

      for (int i = 0; i < SentenceArr.Length; i++)
      if (Word.Equals(SentenceArr[i]))
      {
        frequency++;
      }
      return frequency;
    }
  }
}
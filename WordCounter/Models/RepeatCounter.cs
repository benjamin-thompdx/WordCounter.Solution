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

    public int NoPartialWordFrequency()
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
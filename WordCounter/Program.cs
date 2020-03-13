using System;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Word Counter!");
      Console.WriteLine("Enter a sentence:");
      string sentence = Console.ReadLine();
      Console.WriteLine("Enter a number you want us to count:");
      string word = Console.ReadLine();
      RepeatCounter newRepeatCounter = new RepeatCounter(sentence, word);
      Console.WriteLine("--------");
      Console.WriteLine("The word " + "(" + newRepeatCounter.Word + ")" + " is displayed " + newRepeatCounter.GetRepeatWordFrequency() + " times within your sentence.");
      Console.WriteLine("--------");
      Console.WriteLine("Would you like to play again? Enter Yes or No");
      string userInput1 = Console.ReadLine().ToLower();
      if(userInput1 == "yes")
      {
        Main();
      }
      else if (userInput1 == "no")
      {
        Console.WriteLine("Thanks for playing!");
      }
      else
      {
        Console.WriteLine("Sorry we didn't get that. Please enter 'Yes' to play again, or 'No' to quit");
        string userInput2 = Console.ReadLine();
        if(userInput2 == "yes")
        {
          Main();
        }
        else
        {
          Console.WriteLine("Thanks for playing!");
        }
      }

    }
  }
}
using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Scrabble Scorrer!");

      Console.WriteLine("Enter a word");

      string word = Console.ReadLine();
      string upperWord = word.ToUpper();

      Game newGame = new Game(upperWord);
      char[] arrayWord = newGame.MakeArray(upperWord);
      Console.WriteLine(newGame.Count(arrayWord));
    


    }
  }
}
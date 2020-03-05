using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Game
  {
    public string Word { get; set; }
    public int Sum {get; set;}
    private static Dictionary<char, int> _gameDictionary = new Dictionary <char, int>()
    {
      {'A',1},{'E', 1}, {'I', 1}, {'O', 1}, {'U', 1}, {'L', 1}, {'N',1}, {'R',1}, {'S',1}, {'T', 1}, {'D', 2}, {'G', 2}, {'B', 3}, {'C', 3}, {'M', 3}, {'P', 3}, {'F', 4}, {'H', 4}, {'V', 4}, {'W', 4}, {'Y', 4}, {'K', 5}, {'J', 8}, {'X', 8}, {'Q', 10}, {'Z', 10}
    };

    public Game(string scoreWord)
    {
      Word = scoreWord;
      
    }
   

    public char[] MakeArray(string scoreWord)
    {
      char[] arrayWord = scoreWord.ToCharArray(0, scoreWord.Length);
      return arrayWord;
    }
    
    public int Count(char[] arrayWord)
    {
      
      foreach (char character in arrayWord)
      {
        if(_gameDictionary.ContainsKey(character))
          {
            Sum += _gameDictionary[character];
          }
        else 
          {
            Sum += 0;
          }
      }
       
        return Sum;
    }
    // public static Dictionary<char, int> GetAll()
    // {
    //   return _gameDictionary;
    // }
    // public static Dictionary<int, char[]> SetAll()
    // {
    //   Dictionary<int, char[]> _gameDictionary.Add( 1, ['A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' ]);
    //   return _gameDictionary;
    // }
  } 
}
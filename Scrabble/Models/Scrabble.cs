namespace Scrabble.Models
{
  public class Game
  {
    public string Word { get; set; }

    public Game(string word)
    {
      Word = word;
    }
  } 
}
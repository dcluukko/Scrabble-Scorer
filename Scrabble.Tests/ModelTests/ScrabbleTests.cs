using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;
using System.Collections.Generic;

namespace Scrabble.Tests
{
  [TestClass]
  public class GameTest
  {

    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("hi");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GameConstructor_SetVaules_Game()
   {
     Game newGame = new Game("hi");
     Assert.AreEqual("hi", newGame.Word);
   }

   [TestMethod]
   public void MakeArray_ConvertsStringToArray_Array()
   {
     Game newGame = new Game("hello");
     char[] result = {'h', 'e', 'l', 'l', 'o'};
     CollectionAssert.AreEqual(result, newGame.MakeArray("hello"));
   }
   [TestMethod]
   public void Count_CountValueSumOfArray_Integer()
   {
     Game newGame = new Game("MAP");
     char[] intoArray = newGame.MakeArray("MAP");
     int result = newGame.Count(intoArray);

     Assert.AreEqual(result, 7);
   }

  //  [TestMethod]
  //  public void GetAll_CreateEmptyDictionary_Dictionary()
  //  {
  //    Dictionary<char, int> _gameDictionary = new Dictionary <char, int>(){};
  //    Dictionary<char, int> result = Game.GetAll();
  //    CollectionAssert.AreEqual(result, _gameDictionary);
  //  }

  }
}
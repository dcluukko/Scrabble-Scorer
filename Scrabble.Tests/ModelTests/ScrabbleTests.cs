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
   public void GetAll_CreateEmptyDictionary_Dictionary()
   {
    //  Game newGame = new Game("hello");
     Dictionary<int, char[]> _gameDictionary = new Dictionary <int, char[]>(){};
     Dictionary<int, char[]> result = Game.GetAll();
     CollectionAssert.AreEqual(result, _gameDictionary);
   }
  }
}
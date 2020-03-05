using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;

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
  }
}
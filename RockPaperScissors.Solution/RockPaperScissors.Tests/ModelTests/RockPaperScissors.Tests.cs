using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RPC.Models;

namespace RPC.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void RPCWinner_InputsAreSame_String()
    {
      string player1Input = "Rock";
      string player2Input = "Rock";

      string result = Game.RPCWinner(player1Input, player2Input);
      Assert.AreEqual("Draw", result);
    }

    [TestMethod]
    public void RPCWinner_RockWins_String()
    {
      string player1Input = "Rock";
      string player2Input = "Scissors";

      string result = Game.RPCWinner(player1Input, player2Input);
      Assert.AreEqual("rock wins!", result);
    }

    [TestMethod]
    public void RPCWinner_PaperWins_String()
    {
      string player1Input = "rock";
      string player2Input = "paper";

      string result = Game.RPCWinner(player1Input, player2Input);
      Assert.AreEqual("paper wins!", result);
    }
    [TestMethod]
    public void RPCWinner_ScissorsWins_String()
    {
      string player1Input = "scissors";
      string player2Input = "paper";

      string result = Game.RPCWinner(player1Input, player2Input);
      Assert.AreEqual("scissors wins!", result);
    }
  }
}

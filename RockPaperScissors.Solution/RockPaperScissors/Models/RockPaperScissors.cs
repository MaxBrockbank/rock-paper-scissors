using System;
using System.Collections.Generic;

namespace RPC.Models{

  public class Game{
    public static string RPCWinner(string player1, string player2) {
      string player1Input = player1.ToLower();
      string player2Input = player2.ToLower();

      if (player1Input == player2Input) 
      {
        return "Draw";
      }
      else if ((player1Input == "rock" && player2Input=="scissors") || (player2Input == "rock" && player1Input=="scissors"))
      {
        return "rock wins!";
      } 
      else if((player1Input =="rock" && player2Input=="paper") || (player2Input =="rock" && player1Input=="paper"))
      {
        return "paper wins!";
      }
      else if((player1Input == "paper" && player2Input == "scissors") || (player2Input == "paper" && player1Input == "scissors"))
      {
        return "scissors wins!";
      }
      else
      {
        return "pick rock, paper or scissors you dummies";
      }
    }
  }

}
using System;
using System.Collections.Generic;

namespace RPC.Models
{
    public class Program
    {
      static void Main()
      {
        Console.WriteLine("Player 1 enter rock, paper or scissors");
        string player1Input = Console.ReadLine();
        Console.WriteLine("Player 2 enter rock, paper or scissors -- and don't look at what player1 wrote!!");
        string player2Input = Console.ReadLine();

        string result = Game.RPCWinner(player1Input, player2Input);
        Console.WriteLine(result);
      }
    }
}
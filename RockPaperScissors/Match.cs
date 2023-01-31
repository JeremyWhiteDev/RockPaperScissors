using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static RockPaperScissors.Game;

namespace RockPaperScissors;

public class Match
  {
    private Player _player;

    private NPC _npc;

    private string rock = @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)";

   private  string paper = @"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)";

   private string scissors = @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)";



    public Match(Player player, NPC npc) 
    {

       _player= player;
        _npc= npc;  
     

    }
    public void Run() {
        DisplayScoreboardAndOptions();

        string input = Console.ReadLine();
        _player.Choice = int.Parse(input);

        _npc.Choice = _npc.GetRandomChoice();

        if (_player.Choice == _npc.Choice) 
        {
            Console.WriteLine("It's a draw! Try again!");
        } else if (_player.Choice == 1 && _npc.Choice == 2) 
        {
            _npc.Score += 1;
            Console.Clear();
            DisplayScoreboardAndOptions();
            Console.WriteLine(rock);
            Console.WriteLine("VS");
            Console.WriteLine(paper);
        }
        else if (_player.Choice == 1 && _npc.Choice == 3)
        {
            _player.Score += 1;
            Console.Clear();
            DisplayScoreboardAndOptions();
            Console.WriteLine(rock);
            Console.WriteLine("VS");
            Console.WriteLine(scissors);
        }
        else if (_player.Choice == 2 && _npc.Choice == 1)
        {
            _player.Score += 1;
            Console.Clear();
            DisplayScoreboardAndOptions();
            Console.WriteLine(paper);
            Console.WriteLine("VS");
            Console.WriteLine(rock);
        }
        else if (_player.Choice == 2 && _npc.Choice == 3)
        {
            _npc.Score += 1;
            Console.Clear();
            DisplayScoreboardAndOptions();
            Console.WriteLine(paper);
            Console.WriteLine("VS");
            Console.WriteLine(scissors);
        }
        else if (_player.Choice == 3 && _npc.Choice == 1)
        {
            _npc.Score += 1;
            Console.Clear();
            DisplayScoreboardAndOptions();
            Console.WriteLine(scissors);
            Console.WriteLine("VS");
            Console.WriteLine(rock);
        }
        else if (_player.Choice == 3 && _npc.Choice == 2)
        {
            _player.Score += 1;
            Console.Clear();
            DisplayScoreboardAndOptions();
            Console.WriteLine(scissors);
            Console.WriteLine("VS");
            Console.WriteLine(paper);
        }
        Console.ReadLine();

    }
    private void DisplayScoreboardAndOptions()
    {

        var enumValues = Enum.GetValues<GameOptions>();

        Console.WriteLine($@"
-----------------------------
| Player: {_player.Score}  | Computer: {_npc.Score}  |
-----------------------------");
        Console.WriteLine("Play Rock Paper Scissors!!");
        Console.WriteLine("What would you like to throw?");
        foreach (GameOptions enumValue in (GameOptions[])enumValues)
        {
            Console.WriteLine($"{(int)enumValue}) {enumValue}");
        }
    }
}

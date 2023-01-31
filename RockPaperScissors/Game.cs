using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors;

public class Game
{
    NPC NPC { get; set; }   
    Player Player { get; set; }

    public enum GameOptions
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }


    public Game()
    {
        NPC = new NPC();
        Player = new Player();
    }
  public void Run()
    {

        bool running = true;

        while (running)
        {
        Match match= new Match(Player, NPC);
            match.Run();
           Console.Clear();

        }
        Console.ReadLine();
    }
}

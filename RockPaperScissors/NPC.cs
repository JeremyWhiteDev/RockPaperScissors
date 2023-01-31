using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors;

public class NPC
{
    public int Choice { get; set; }
    public int Score { get; set; }

    public int GetRandomChoice()
    {
        Random rnd = new Random();

        return rnd.Next(1, 4);
    }
}
